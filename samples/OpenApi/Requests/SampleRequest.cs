using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace OpenApi.Requests
{
    public class SampleRequest : IRequest<SampleResponse>
    {
        public int Id { get; set; }
    }

    public class SampleResponse
    {
        public string Name { get; set; }

        public DateTime Timestamp { get; set; }
    }

    public class SampleRequestHandler : IRequestHandler<SampleRequest, SampleResponse>
    {
        [HttpPost("SampleRequest")]
        public async Task<SampleResponse> Handle(SampleRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(200);

            return new SampleResponse
            {
                Name = "Kahbazi",
                Timestamp = DateTime.Now
            };
        }
    }
}
