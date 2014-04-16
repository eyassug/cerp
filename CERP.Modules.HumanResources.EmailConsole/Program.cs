using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading;
using CERP.Modules.HumanResources.EmailConsole.Models;
using CERP.Modules.HumanResources.EmailConsole.Services;
using Ninject;

namespace CERP.Modules.HumanResources.EmailConsole
{
    class Program
    {
        static IPaySlipMailService _paySlipMailService;
        public static IKernel Kernel;
        public static string ConnectionString
        {
            get { return @"Data Source=.;Initial Catalog=CERP;Integrated Security=True;"; }
        }

        public static string TemporaryFileDirectory
        {
            get { return @"E:\PaySlips"; }
        }

        #region Kernel Initialisation
        static Program()
        {
            Kernel = new StandardKernel(new HumanResourcesModule(new HumanResourcesModuleConfiguration
                                                                      {
                                                                          ConnectionString = ConnectionString
                                                                      }));
            if (!Directory.Exists(TemporaryFileDirectory))
                Directory.CreateDirectory(TemporaryFileDirectory);
            _paySlipMailService = new PaySlipMailService();
        }

        #endregion

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    CheckForAndSendQueuedSlips();
                }
                catch (Exception)
                {

                }
                
                Thread.Sleep(TimeSpan.FromSeconds(30));
            }
            
        }

        static void CheckForAndSendQueuedSlips()
        {
            // Clear temp directory
            ClearTempDirectory();

            var queuedPaySlips = _paySlipMailService.GetQueuedPaySlips();
            while (queuedPaySlips.Any())
            {
                var slip = queuedPaySlips.Peek();
                try
                {
                    _paySlipMailService.SendPaySlip(slip);
                    queuedPaySlips.Dequeue();
                }
                catch (SmtpException)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(30));
                }
            }
        }

        static void ClearTempDirectory()
        {
            var files = Directory.GetFiles(TemporaryFileDirectory);
            foreach (var file in files)
            {
                File.Delete(file);
            }
        }

    }
}
