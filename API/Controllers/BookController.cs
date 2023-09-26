using API.AppServices.Services.BookServices;
using API.Contracts.DTOs.BookDTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger, IBookService bookService)
    {
        _logger = logger;
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        try
        {
            var response = _bookService.GetAll();
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(new EventId(), ex, ex.Message);
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        try
        {
            var response = await _bookService.GetByIdAsync(id);
            return Ok(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(new EventId(), ex, ex.Message);
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateBookRequest request)
    {
        try
        {
            await _bookService.CreateAsync(request);
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(new EventId(), ex, ex.Message);
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<IActionResult> Edit([FromBody] EditBookRequest request)
    {
        try
        {
            await _bookService.EditAsync(request);
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(new EventId(), ex, ex.Message);
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _bookService.DeleteAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(new EventId(), ex, ex.Message);
            return BadRequest(ex.Message);
        }
    }
}
