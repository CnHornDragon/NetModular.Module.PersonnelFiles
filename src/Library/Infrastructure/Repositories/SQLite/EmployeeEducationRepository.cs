using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.PersonnelFiles.Infrastructure.Repositories.SQLite
{
    public class EmployeeEducationRepository : SqlServer.EmployeeEducationRepository
    {
        public EmployeeEducationRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}