using System;
using System.Threading;
using ConsoleAppExample.DatabaseRepository;
using Elastic.Apm;

namespace ConsoleAppExample.Businesses
{
    internal class BusinessRepository
    {
        private readonly IDatabaseRepository databaseRepository;

        public BusinessRepository()
        {
            var rng = new Random();
            databaseRepository = rng.Next(2) == 1 ? new PSQLRepository() : (IDatabaseRepository)new MSSQLRepository();
        }

        public string SmallBusiness()
        {
            var transaction = Agent.Tracer.StartTransaction("Small Business", "Business");
            try
            {
                CreateDatabaseOperation();
                Thread.Sleep(100);
                return "small business done sucessfully";
            }
            catch (Exception e)
            {
                transaction.CaptureException(e);
                return "exception throwed";
            }
            finally
            {
                transaction.End();
            }
        }

        public string MediumBusiness()
        {
            var transaction = Agent.Tracer.StartTransaction("Medium Business", "Business");
            try
            {
                CreateDatabaseOperation();
                Thread.Sleep(200);
                return "medium business done sucessfully";
            }
            catch (Exception e)
            {
                transaction.CaptureException(e);
                return "exception throwed";
            }
            finally
            {
                transaction.End();
            }
        }

        public string Longbusiness()
        {
            var output = Agent.Tracer.CaptureTransaction("Long Business", "Business", (t) =>
            {
                CreateDatabaseOperation();
                Thread.Sleep(300);
                return "long business done sucessfully";
            });

            return output;
        }

        private void CreateDatabaseOperation()
        {
            var rng = new Random();
            var dbTransactionType = rng.Next(1, 5);

            switch (dbTransactionType)
            {
                case 1:
                    databaseRepository.Create();
                    break;
                case 2:
                    databaseRepository.Read();
                    break;
                case 3:
                    databaseRepository.Update();
                    break;
                case 4:
                    databaseRepository.Delete();
                    break;
            }
        }
    }
}