﻿using TransChartDemo.Models;

namespace TransChartDemo.Repositories
{
    public interface IBankDataRepository
    {
        BankData GetBankData(int id);
        void AddBankData(BankData bankData);
        void UpdateBankData(BankData bankData);
        void DeleteBankData(int id);
        List<BankData> GetAllBankData();

    }
}
