namespace AngularRestApi.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly AngularRestApiDbContext _context;

        public InitialHostDbBuilder(AngularRestApiDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new GoodsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
