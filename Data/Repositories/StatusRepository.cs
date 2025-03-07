using Data.Contexts;
using Data.Entities;
using Data.Interfaces;

namespace Data.Repositories;

public class StatusRepository(MyDBContext context) : BaseRepository<StatusEntity>(context), IStatusRepository
{

}
