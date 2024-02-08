using TransChartDemo.Models;

namespace TransChartDemo.Repositories
{
    public interface IAnnualTransactionsRepository
    {
        AnnualTransactions GetAnnualTransactions(int bankName);
        void AddAnnualTransactions(AnnualTransactions bankData);
        void UpdateAnnualTransactions(AnnualTransactions bankData);
        void DeleteAnnualTransactions(int id);
        List<AnnualTransactions> GetAllAnnualTransactions();
    }
}
