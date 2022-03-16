using System;
using Microsoft.EntityFrameworkCore;
using server.EntityModels;
{ 
    public class ModOfTransaction
    {
        public ModOfTransactionDao()
        {
        }
        public bool InsertModOfTransaction(ModOfTransaction modOfTransaction)
        {
            int res = 0;
            try
            {
               using (var db = new BankingContext())
               {
                  DbSet<ModOfTransaction> allModOfTransaction= db.ModOfTransaction;
                  ModOfTransaction entityModelObject = new ModOfTransaction
                  {
                    ModeId=modOfTransaction.ModeId,
                    Modes=modOfTransaction.Modes,
                    MaturityInstruction=modOfTransaction.MaturityInstruction


                  };
                  allModOfTransaction.Add(entityModelObject);
                  result = db.SaveChanges();
               }
               return res > 0;
            }
            catch (Exception ex)
            {
                throw ex;
        }
       
    }
    public bool UpdateModOfTransaction(UpdateModOfTransaction modOfUpdateTransaction)
    {
        int result = 0;
        try
        {
            using (var db = new BankingContext())
            {
                Db<ModOfTransaction> allModOfTransaction = db.ModOfTransaction;
                ModOfTransaction entityModelObject = new ModOfTransaction
                {
                    ModeId = modOfUpdateTransaction.ModeId,
                    Modes = modOfUpdateTransaction.Modes,
                    MaturityInstruction = modOfUpdateTransaction.MaturityInstruction


                };
                allModOfTransaction.Add(entityModelObject);
                result = db.SaveChanges();
            }
            return result > 0;
        }
        catch (Exception ex)
        {
           throw ex;
        }
    }
     
}







