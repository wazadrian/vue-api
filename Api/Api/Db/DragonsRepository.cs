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
                new Dragon(1,"Camis, Longtail","","black","fire",new string[]{ }),
                new Dragon(2,"Belry, The Skinny One","","yellow","acid",new string[]{ }),
                new Dragon(3,"Ykeo, The Tender","","blue","fire",new string[]{ }),
                new Dragon(4,"Luseiroiss, The Warrior","","red","water",new string[]{ }),
                new Dragon(5,"Kadram, The Voiceless","","brown","fire",new string[]{ }),
                new Dragon(6,"Yzzen, The White","","white","poison",new string[]{ }),
                new Dragon(7,"Asad, Warmheart","","red","fire",new string[]{ }),
                new Dragon(8,"Aideinth, The Kind","","green","acid",new string[]{ }),
                new Dragon(9,"Teivro, Lord Of The Brown","","green","corrosion",new string[]{ }),
            };
            return data;
        }
        public static Dragon GetById(int id)
        {
            return DragonsRepository.GetAll().First(x => x.Id == id);
        }
    }
}