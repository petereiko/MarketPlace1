using MarketPlace.Business.Modules.Auth;
using MarketPlace.Business.Modules.Notification;
using MarketPlace.Data.DataObjects.ApplicationConfig;
using MarketPlace.Data.Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Data;

namespace MarketPlace.Business
{
    public static class AppBootstrapper
    {
        public static void InitServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.AddHttpClient("SmsClient").ConfigureHttpClient(c =>
            {
                c.Timeout = TimeSpan.FromMinutes(5);
            });
            //services.AddScoped<APIActionFilter>();
            //services.AddScoped<AdminUserFilter>();
            services.AddScoped(x =>
            {
                var actionContext = x.GetRequiredService<IActionContextAccessor>().ActionContext;
                var factory = x.GetRequiredService<IUrlHelperFactory>();
                if (actionContext != null)
                {
                    return factory.GetUrlHelper(actionContext);
                }
                return null;
            });

            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            



            //services.AddTransient<DbContext, ApplicationDbContext>();
            //services.AddTransient(typeof(DbContextOptions<ApplicationDbContext>));


            services.AddScoped<ISmsService, SmsService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddTransient<IAccountService, AccountService>();
            //services.AddTransient<ICountry, CountryServices>();


            //services.AddTransient<IEmailing, EmailingServices>();
            //services.AddTransient<IActivityLog, ActivityLogServices>();
            //services.AddTransient<IFileHandler, FileHandlerServices>();

            // Domain.Core - Identity
            //services.AddTransient<ICommonRoute, CommonRouteServices>();

            //services.AddTransient<IUserManagement, UserManagement>();

            //services.AddTransient<IProviderService, ProviderServices>();
            //services.AddTransient<IFireBaseService, FireBaseService>();
            //services.AddTransient<IDigitTransaction, DigitTransactionService>();
            //services.AddTransient<IVirtualWalletService, VirtualWalletService>();
            //services.AddTransient<IFundTransferService, FundTransferService>();
            //services.AddTransient<IAdminService, AdminService>();
            //services.AddTransient<IAirtimeService, AirtimeService>();
            //services.AddTransient<IAccountService, AccountServices>();
            //services.AddTransient<IReferralService, ReferralService>();
            //services.AddTransient<IErrorLogger, ErrorLoggerService>();
            //services.AddTransient<IInvestmentService, InvestmentService>();
            //services.AddTransient<IJobService, JobService>();
            //services.AddTransient<IRegisterService, RegisterService>();
            //services.AddTransient<ITransactionLimitService, TransactionLimitService>();
            //services.AddTransient<ITestService, TestService>();
            //services.AddTransient<ISmsManager, SmsManager>();
            //services.AddTransient<IEmailManager, EmailManager>();
            //services.AddTransient<ICatalogueService, CatalogueService>();
            //services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IAuthUser, AuthUser>();
            //services.AddTransient<ISupplierService, SupplierService>();
            //services.AddTransient<ICustomerContactService, CustomerContactService>();
            //services.AddTransient<IOrderService, OrderService>();
            //services.AddTransient<IKYCDocumentService, KYCDocumentService>();
            //services.AddTransient<INIPManager, NIPManager>();
            //services.AddTransient<ILittleDropInvestmentService, LittleDropInvestmentService>();
            //services.AddTransient<IInvestmentTaskManager, InvestmentTaskManager>();
            //services.AddTransient<IVerificationCodeTask, VerificationCodeTask>();
            //services.AddTransient<IReferralTaskManager, ReferralTaskManager>();
            //services.AddTransient<IRegisterService, RegisterService>();
            //services.AddTransient<IBusinessAccountService, BusinessAccountService>();
            //services.AddTransient<IIncomeAndExpensesTrackerService, IncomeAndExpensesTrackerService>();
            //services.AddScoped<IAdminUserService, AdminUserService>();
            //services.AddScoped<IBusinessRegistrationServicce, BusinessRegistrationServicce>();
            //services.AddScoped<IConnectedAppService, ConnectedAppService>();
            //services.AddScoped<IAtlasServiceFeeService, AtlasServiceFeeService>();
            //services.AddScoped<IUserOperationService, UserOperationService>();
            //services.AddRestEaseClient<IInterswitchApi>(appSettings.Interswitch.BaseUrl)
            //   .SetHandlerLifetime(TimeSpan.FromMinutes(5)).ConfigureHttpClient(x => new HttpClient(new CustomHttpClientHandler()));
            //services.AddRestEaseClient<IWalletApi>(virtualWalletServiceSetting.BaseUrl)
            // .SetHandlerLifetime(TimeSpan.FromMinutes(5)).ConfigureHttpClient(x => new HttpClient(new CustomHttpClientHandler()));
            //services.AddRestEaseClient<IInterswitchAuthApi>(appSettings.Interswitch.AuthBaseUrl)
            // .SetHandlerLifetime(TimeSpan.FromMinutes(5));
            //services.AddScoped<IInterswitchServices, InterswitchServices>();
            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<ITransactionHistoryService, TransactionHistoryService>();
            //services.AddScoped<ITimedOutBillService, TimedOutBillService>();
            //services.AddScoped<Integration.Interface.IPaystackService, PaystackService>();
            //services.AddScoped<EncryptionBodyHelper>();
            //services.AddScoped<IAzureBlobService, AzureBlobService>();
            //services.AddScoped<ISecurityDetailsService, SecurityDetailsService>();
            //services.AddScoped<IPasswordService, PasswordService>();
            //services.AddScoped<IAccountUpgradeService, AccountUpgradeService>();
            //services.AddScoped<IFaqService, FaqService>();
            //services.AddScoped<ISmsService, SmsService>();
            //services.AddScoped<ICustomersService, CustomersService>();
            //services.AddScoped<IOTPService, OTPService>();
            //services.AddScoped<ISideHustleService, SideHustleService>();
            //services.AddScoped<ICustomerAuditLogService, CustomerAuditLogService>();
            //services.AddScoped<IAccountModuleService, AccountModuleService>();
            //services.AddScoped<ISavingService, SavingService>();
            //services.AddRestEaseClient<ILoansIntegration>(appSettings.LoanSettings.BaseUrl)
            //  .SetHandlerLifetime(TimeSpan.FromMinutes(5)).ConfigureHttpClient(x => new HttpClient(new CustomHttpClientHandler()));
            //services.AddScoped<IOverdraftService, OverdraftService>();
            //services.AddScoped<ICollateralService, CollateralService>();
            //services.AddScoped<IAssetFinanceService, AssetFinanceService>();
            //services.AddScoped<IAutoReversalService, AutoReversalService>();

            //services.AddScoped<IWorkflowService, WorkflowService>();
            //services.AddScoped<IRequestService, RequestService>();

            //services.AddScoped<IVaultBorrowService, VaultBorrowService>();
            //services.AddScoped<ILoanService, LoanService>();
            //services.AddScoped<IPdfTemplateService, PdfTemplateService>();
            //services.AddScoped<IUserIdentityVerificationService, UserIdentityVerificationService>();
            //services.AddScoped<ISignupTrackingService, SignupTrackingService>();
            //services.AddScoped<IDeviceService, DeviceService>();
            //services.AddScoped<ICardService, CardService>();
            //services.AddRestEaseClient<IBatchTransactionApi>(virtualWalletServiceSetting.BaseUrl)
            //.SetHandlerLifetime(TimeSpan.FromMinutes(5)).ConfigureHttpClient(x => new HttpClient(new CustomHttpClientHandler()));
            //services.AddScoped<IBatchTransactionService, BatchTransactionService>();
        }
    }
}
