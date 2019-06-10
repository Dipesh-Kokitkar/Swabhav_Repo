using System;
namespace InterfaceApp.Curd
{
    interface ICurdable
    {
        string Create();
        string Read();
        string Update();
        string Delete();
    }
}
