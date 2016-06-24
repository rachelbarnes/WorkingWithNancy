using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrays
{
    //code exercise: rotate an array of n elements to the right by k steps
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Rotate
    {
        //this method takes a list and a staring point
        public List<int> RotateList(List<int> originalList, int rotateBy)
        {
            var element = 0;
            var rotatedList = new List<int>();
            for (int place = 0; place < originalList.Count; place++)
            {
                if (rotateBy > place)
                {
                    element = place + rotateBy - 1 ;
                }
                if (rotateBy < place)
                {
                    element = place - (rotateBy - 1);
                }
                rotatedList.Add(originalList[element]);
            }
            return rotatedList;
        }
    }
}























//        public List<int> Rotation(List<int> originalList, int rotatedPlace)// when inputing an int for rotatedPlace, count for 0 based indexing
//        {
//            var _rotatedPlace = rotatedPlace; 
//            var newElement = 0;
//            var rotatedList = new List<int>();
//            for (int place = 0; place<originalList.Count; place++, rotatedPlace++)
//            {
//                if (rotatedPlace < place)
//                {
//                    place = place - rotatedPlace; 
//                }
//                if (rotatedPlace > place)
//                {
//                    place = rotatedPlace - _rotatedPlace - 1;  
//                }
//                newElement = originalList[place]; 
//                rotatedList.Add(newElement); 
//               }
//            return rotatedList; 
//        }
//    }
//}
////now try this with tdd
