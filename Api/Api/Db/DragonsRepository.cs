using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Db
{
    public static class DragonsRepository
    {
        public static Dragon[] GetAll()
        {
            var data = new Dragon[]
            {
                new Dragon(1,"Camis, Longtail","http://placekitten.com/200/600","black","fire",new string[]{ }),
                new Dragon(2,"Belry, The Skinny One","http://placekitten.com/400/400","yellow","acid",new string[]{ }),
                new Dragon(3,"Ykeo, The Tender","http://placekitten.com/340/322","blue","fire",new string[]{ }),
                new Dragon(4,"Luseiroiss, The Warrior","http://placekitten.com/756/453","red","water",new string[]{ }),
                new Dragon(5,"Kadram, The Voiceless","http://placekitten.com/200/222","brown","fire",new string[]{ }),
                new Dragon(6,"Yzzen, The White","http://placekitten.com/433/600","white","poison",new string[]{ }),
                new Dragon(7,"Asad, Warmheart","http://placekitten.com/543/876","red","fire",new string[]{ }),
                new Dragon(8,"Aideinth, The Kind","http://placekitten.com/122/524","green","acid",new string[]{ }),
                new Dragon(9,"Teivro, Lord Of The Brown","http://placekitten.com/443/222","green","corrosion",new string[]{ }),
            };
            return data;
        }
        public static Dragon GetById(int id)
        {
            return DragonsRepository.GetAll().First(x => x.Id == id);
        }
    }
}