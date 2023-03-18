
using System.Collections;
// using System.Enum;
namespace SqlOrm.SqlClauses;


enum AffectedRows : int
{
    Rows
}
internal interface ISqlSelect<T>
{
    IEnumerable<T> Select();
}

internal interface ISqlUpdate<T>
{

}