using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using MySql.Data.MySqlClient;

namespace Service {
    public class MusicService : IMusicService {
        private static DatabaseManager DB = DatabaseManager.Instance();
        private static Dictionary<string, User> Users = new Dictionary<string, User>();
        public static List<Music> Musics = new List<Music>();

        public bool Add(string name, string link, string uID) {
            try {
                if (Users.ContainsKey(uID)) {
                    if (DB.Connect()) {
                        int editedRows = DB.ExecuteNonQuery(string.Format("INSERT INTO musics (name, link) VALUES ('{0}', '{1}')", name, link));
                        DB.Close();
                        return editedRows == 1;
                    } else throw new Exception("Database connection error");
                } else throw new Exception("Log in first");
            } catch (Exception e) {
                throw new FaultException<MyException>(new MyException(e.Message));
            }
        }

        public List<Music> List(string uID) {
            try {
                if (Users.ContainsKey(uID)) {
                    if (DB.Connect()) {
                        lock (typeof(MySqlDataReader)) {
                            MySqlDataReader r = DB.DataReader(string.Format("SELECT * FROM musics"));
                            if (r.HasRows) {
                                lock (Musics) {
                                    Musics = new List<Music>();
                                    while (r.Read()) Musics.Add(new Music(r.GetUInt32(0), r.GetString(1), r.GetString(2), r.GetUInt32(3), r.GetUInt32(4)));
                                }
                            }
                            r.Close();
                            DB.Close();
                        }
                    } else throw new Exception("Database connection error");
                } else throw new Exception("Log in first");
                return Musics;
            } catch (Exception e) {
                throw new FaultException<MyException>(new MyException(e.Message));
            }
        }

        public bool? getLike(uint musicID, string uID) {
            try {
                if (Users.ContainsKey(uID)) {
                    if (DB.Connect()) {
                        bool? like = null;
                        lock (typeof(MySqlDataReader)) {
                            MySqlDataReader r = DB.DataReader(string.Format("SELECT type FROM musics_users_likes WHERE music_id = {0} AND user_id = {1}", musicID, Users[uID].Id));
                            if (r.HasRows) {
                                while (r.Read()) {
                                    like = r.GetBoolean(0);
                                }
                            }
                            r.Close();
                            DB.Close();
                        }
                        return like;
                    } else throw new Exception("Database connection error");
                } else throw new Exception("Log in first");
            } catch (Exception e) {
                throw new FaultException<MyException>(new MyException(e.Message));
            }
        }

        public bool Like(uint musicID, string uID) {
            try {
                if (Users.ContainsKey(uID)) {
                    bool? userLikeState = getLike(musicID, uID);
                    if (userLikeState == true) throw new Exception("Already liked this song");
                    if (DB.Connect()) {

                        int editedRows = 0;

                        lock (typeof(MySqlDataReader)) {
                            MySqlDataReader r = DB.DataReader(string.Format("SELECT likes, dislikes FROM musics WHERE id = {0}", musicID));
                            uint likes = 0, dislikes = 0;
                            if (r.HasRows) {
                                while (r.Read()) {
                                    likes = r.GetUInt32(0) + 1;
                                    dislikes = r.GetUInt32(1) - (uint)(userLikeState == false ? 1 : 0);
                                    break;
                                }
                                r.Close();

                                editedRows = DB.ExecuteNonQuery(string.Format("UPDATE musics SET likes = {0}, dislikes = {1} WHERE id = {2}", likes, dislikes, musicID));
                                editedRows += DB.ExecuteNonQuery(
                                    (userLikeState == null)
                                    ? string.Format("INSERT INTO musics_users_likes (music_id, user_id, type) VALUES ({0}, {1}, true)", musicID, Users[uID].Id)
                                    : string.Format("UPDATE musics_users_likes SET type = true WHERE music_id = {0} AND user_id = {1}", musicID, Users[uID].Id)
                                );

                            }

                            DB.Close();
                        }
                        return editedRows == 2;
                    } else throw new Exception("Database connection error");
                } else throw new Exception("Log in first");
            } catch (Exception e) {
                throw new FaultException<MyException>(new MyException(e.Message));
            }
        }
        public bool Dislike(uint musicID, string uID) {
            try {
                if (Users.ContainsKey(uID)) {
                    bool? userLikeState = getLike(musicID, uID);
                    if (userLikeState == false) throw new Exception("Already disliked this song");
                    if (DB.Connect()) {
                        int editedRows = 0;
                        lock (typeof(MySqlDataReader)) {
                            MySqlDataReader r = DB.DataReader(string.Format("SELECT likes, dislikes FROM musics WHERE id = {0}", musicID));
                            uint likes = 0, dislikes = 0;
                            if (r.HasRows) {
                                while (r.Read()) {
                                    likes = r.GetUInt32(0) - (uint)(userLikeState == true ? 1 : 0);
                                    dislikes = r.GetUInt32(1) + 1;
                                    break;
                                }
                                r.Close();

                                editedRows = DB.ExecuteNonQuery(string.Format("UPDATE musics SET likes = {0}, dislikes = {1} WHERE id = {2}", likes, dislikes, musicID));
                                editedRows += DB.ExecuteNonQuery(
                                    (userLikeState == null)
                                    ? string.Format("INSERT INTO musics_users_likes (music_id, user_id, type) VALUES ({0}, {1}, false)", musicID, Users[uID].Id)
                                    : string.Format("UPDATE musics_users_likes SET type = false WHERE music_id = {0} AND user_id = {1}", musicID, Users[uID].Id)
                                );
                            }
                            DB.Close();
                        }
                        return editedRows == 2;
                    } else throw new Exception("Database connection error");
                } else throw new Exception("Log in first");
            } catch (Exception e) {
                throw new FaultException<MyException>(new MyException(e.Message));
            }
        }
        public bool Delete(uint musicID, string uID) {
            try {
                if (Users.ContainsKey(uID)) {
                    if (DB.Connect()) {
                        int editedRows = DB.ExecuteNonQuery(string.Format("DELETE FROM musics WHERE id = {0}", musicID));
                        DB.ExecuteNonQuery(string.Format("DELETE FROM musics_users_likes WHERE music_id = {0}", musicID));
                        DB.Close();
                        return editedRows == 1;
                    } else throw new Exception("Database connection error");
                } else throw new Exception("Log in first");
            } catch (Exception e) {
                throw new FaultException<MyException>(new MyException(e.Message));
            }
        }

        public string Login(string username, string password) {
            try {
                string uID = string.Empty;
                DB = DatabaseManager.Instance();

                if (DB.Connect()) {
                    MySqlDataReader dataReader = DB.DataReader(string.Format("SELECT id, username FROM users WHERE username ='{0}' && password = md5('{1}')", username, password));
                    if (dataReader.HasRows) {
                        User user = null;
                        while (dataReader.Read()) {
                            user = new User(uint.Parse(dataReader.GetString(0)), dataReader.GetString(1));
                        }
                        uID = Guid.NewGuid().ToString();
                        Users.Add(uID, user);
                    } else uID = "WRONG_LOGIN_INFO";
                    dataReader.Close();
                    DB.Close();
                } else throw new Exception("Database connection error");
                return uID;
            } catch (Exception e) {
                throw new FaultException<MyException>(new MyException(e.Message));
            }
        }

        public bool Logout(string uID) {
            try {
                if (Users.ContainsKey(uID)) return Users.Remove(uID);
                else return false;
            } catch (Exception e) {
                throw new FaultException<MyException>(new MyException(e.Message));
            }
        }
    }
}
