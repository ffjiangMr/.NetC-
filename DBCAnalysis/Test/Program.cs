using EOSeViewer.CANComponent.Handle;
using EOSeViewer.DBCAnalysis.Handle;
using EOSeViewer.DBCAnalysis.Infrastructure;
using System;
using EOSeViewer.SaveComponent.Handler;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {            
            var dbc =new  DBCHandler(@"d:\pma.dbc");
            dbc.LoadDBC();
            var wgerg = DateTime.Now.ToString("yyyyMMddHHmmss");
            DBHandler handler = DBHandler.Instance();
            handler.DeleteAllRecord();
            handler.DeleteTable();
            Console.Read();
        }
    }
}
