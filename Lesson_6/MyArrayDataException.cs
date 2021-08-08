using System;


namespace Lesson_6
{
    public enum ErrorCodes
    {
        ItIsNotInt,
        NoBuilding,
    }


    [Serializable]
    class MyArrayDataException: Exception
    {
        
        public ErrorCodes Code { get; }





        public MyArrayDataException(ErrorCodes code)
        {
            Code = code;
        }





        static int CheckToInter(char symbil)
        {
            if (Char.IsDigit(symbil))
            {
                return symbil;
            }
            throw new Exception();
        }

    }
}
