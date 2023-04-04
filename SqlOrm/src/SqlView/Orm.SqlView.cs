
using SqlOrm.Interfaces.SqlView;


namespace SqlOrm.SqlView;

    public abstract class OrmView
    {
        public abstract void Create();

        public abstract string Schema();
    }   

