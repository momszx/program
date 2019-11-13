using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerverZH
{
    class Poszt
    {
        
        private static int nextId;
        public int NextId {
            get
            {
                return nextId;
            }
            set
            {
            }
        }

        private int posztId=1;
        public int PostId { 
            get 
            {
                return posztId;
            }
            set
            {
                PostId = value;
            }
                
                }

        private string postSzoveg;
        public string Postszoveg {
            get
            {
                return postSzoveg;
            }

            set
            {
                postSzoveg = value;
            }
            }

        private string tulajdonos;
        public string Tulajdonos {
            get 
            {
                return tulajdonos;
            }
            set
            { 
                tulajdonos = value;
            } 
        }

        private int like;
        public int Like
        {
            get
            {
                return like;
            }
            set
            {
                like = value;
            }
        }

        private int dislike;
        public int Dislike
        {
            get
            {
                return dislike;
            }
            set
            {
                dislike = value;
            }
        }

        public Poszt(string postSzoveg, string tulajdonos)
        {
            this.postSzoveg = postSzoveg;
            this.tulajdonos = tulajdonos;
            nextId++;
            posztId = nextId;

        }
        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}", tulajdonos, postSzoveg, like, dislike);
        }
    }
}
