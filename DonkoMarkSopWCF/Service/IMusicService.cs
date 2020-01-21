using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Service {
    [ServiceContract]
    public interface IMusicService {

        [OperationContract]
        [FaultContract(typeof(MyException))]
        string Login(string username, string password);

        [OperationContract]
        [FaultContract(typeof(MyException))]
        bool Logout(string uID);

        [OperationContract]
        [FaultContract(typeof(MyException))]
        bool Add(string name, string link, string uID);

        [OperationContract]
        [FaultContract(typeof(MyException))]
        bool Delete(uint musicID, string uID);

        [OperationContract]
        [FaultContract(typeof(MyException))]
        bool Like(uint musicID, string uID);

        [OperationContract]
        [FaultContract(typeof(MyException))]
        bool? getLike(uint musicID, string uID);

        [OperationContract]
        [FaultContract(typeof(MyException))]
        bool Dislike(uint musicID, string uID);

        [OperationContract]
        [FaultContract(typeof(MyException))]
        List<Music> List(string uID);

    }

    [DataContract]
    public class Music {
        uint id, like, dislike;
        string name, link;

        [DataMember]
        public uint Id {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Link {
            get { return link; }
            set { link = value; }
        }

        [DataMember]
        public uint Like {
            get { return like; }
            set { like = value; }
        }

        [DataMember]
        public uint Dislike {
            get { return dislike; }
            set { dislike = value; }
        }

        private Music() {
            Id = 0;
            Name = "UNDEFINED";
            Link = "UNDEFINED";
            Like = 0;
            Dislike = 0;
        }

        public Music(string name, string link) : this() {
            Name = name;
            Link = link;
        }

        public Music(uint id, string name, string link) : this(name, link) {
            Id = id;
        }

        public Music(uint id, string name, string link, uint like, uint dislike) : this(id, name, link) {
            Like = like;
            Dislike = dislike;
        }
    }

    [DataContract]
    public class User {
        uint id;
        string name, password;

        [DataMember]
        public uint Id {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Password {
            get { return password; }
            set { password = value; }
        }

        private User() {
            Id = 0;
            Name = "UNDEFINED";
            Password = string.Empty;
        }

        public User(string name, string password) : this() {
            Name = name;
            Password = password;
        }

        public User(uint id, string name) : this(name, string.Empty) {
            Id = id;
        }
    }

    [DataContract]
    public class MyException {

        [DataMember]
        public string Message { get; set; }


        private MyException() {
            Message = string.Empty;
        }

        public MyException(string message) : this() {
            Message = message;
        }
    }
}
