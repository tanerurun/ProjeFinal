﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands.TestimonialCommands;
using UdemyCarBook.Application.Features.Mediator.Queries.TestimonialQueries;

namespace UdemyCarBook.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestimonialsController : ControllerBase
{
    private readonly IMediator _mediator;

    public TestimonialsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> TestimonialList()
    {
        var values = await _mediator.Send(new GetTestimonialQuery());
        return Ok(values);
    }
    [HttpPost]
    public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
    {
        await _mediator.Send(command);
        return Ok("Referans bilgisi eklendi");
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetTestimonial(int id)
    {
        var values = await _mediator.Send(new GetTestimonialByIdQuery(id));
        return Ok(values);
    }
    [HttpDelete]
    public async Task<IActionResult> RemoveTestimonial(int id)
    {
        await _mediator.Send(new RemoveTestimonialCommand(id));
        return Ok("Referans bilgisi silindi");
    }
    [HttpPut]
    public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
    {
        await _mediator.Send(command);
        return Ok("Referans bilgisi güncellendi");
    }
}
