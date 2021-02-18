using System;
using System.Threading;
using Elastic.Apm;
using Elastic.Apm.Api;

namespace ConsoleAppExample.DatabaseRepository
{
    public class MSSQLRepository : IDatabaseRepository
    {
        public void Create()
        {
            var span = Agent.Tracer.CurrentTransaction
                .StartSpan("Create", ApiConstants.TypeDb, ApiConstants.SubtypeMssql, ApiConstants.ActionExec);
            try
            {
                Thread.Sleep(100);
                Console.WriteLine("Create operation done");
            }
            catch (Exception e)
            {
                span.CaptureException(e);
                Console.Error.WriteLine("PostgreSql Create operation Failed");
            }
            finally
            {
                span.End();
            }
        }

        public void Read()
        {
            Agent.Tracer.CurrentTransaction.CaptureSpan("Read", ApiConstants.TypeDb, (s) =>
            {
                Thread.Sleep(100);
                Console.WriteLine("Read operation done");
            }, ApiConstants.SubtypeMssql, ApiConstants.ActionExec);
        }

        public void Update()
        {
            var span = Agent.Tracer.CurrentTransaction
                .StartSpan("Update", ApiConstants.TypeDb, ApiConstants.SubtypeMssql, ApiConstants.ActionExec);
            try
            {
                Thread.Sleep(100);
                Console.WriteLine("Update operation done");
            }
            catch (Exception e)
            {
                span.CaptureException(e);
                Console.Error.WriteLine("PostgreSql Create operation Failed");
            }
            finally
            {
                span.End();
            }
        }

        public void Delete()
        {
            Console.WriteLine("Delete operation done");
        }
    }
}