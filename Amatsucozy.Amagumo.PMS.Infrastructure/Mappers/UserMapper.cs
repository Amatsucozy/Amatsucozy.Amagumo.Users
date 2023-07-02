﻿using Amatsucozy.Amagumo.PMS.Core;
using Amatsucozy.Amagumo.PMS.Infrastructure.Models;
using Amatsucozy.PMS.Shared.Infrastructure.Mappers;
using Riok.Mapperly.Abstractions;

namespace Amatsucozy.Amagumo.PMS.Infrastructure.Mappers;

[Mapper]
public partial class UserMapper : IMapper<User, UserModel>
{
    public partial UserModel Map(User model);

    public partial void Map(User model1, UserModel model2);

    public partial User Map(UserModel model);

    public partial void Map(UserModel model2, User model1);
}