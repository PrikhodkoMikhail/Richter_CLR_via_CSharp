using System;

//Приказываем компилятору проверять код
// на совместимость с CLS
[assembly: CLSCompliant(true)]

namespace SomeLibrary
{
    //Предупрждения выводяться, потому что класс является открытым 
    sealed class SomeLibraryType
    {
        //Предупреждения: возвращаемый тип 'SomeLibrary.SomeLibraryType.Abc()'
        //не является CLS-совместимым
        public UInt32 Abc() { return 0; }

        //Предупреждение: идентификаторы 'SomeLibrary.SomeLibraryType.abc()',
        //отличается только регистром символов, не являются CLS-совместимыми
        public void abc() { }

        //Предупреждения нет: закрытый метод
        private UInt32 ABC() { return 0; }
    }
}
