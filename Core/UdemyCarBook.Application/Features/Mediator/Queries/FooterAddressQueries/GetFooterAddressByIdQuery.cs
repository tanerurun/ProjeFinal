﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.FooterAddressResult;

namespace UdemyCarBook.Application.Features.Mediator.Queries.FooterAddressQueries;
public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
{
    public GetFooterAddressByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
