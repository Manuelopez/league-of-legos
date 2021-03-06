using System.Collections.Generic;

namespace server.Common
{
  public abstract class Payload
  {
    protected Payload(IReadOnlyList<UserError>? errors = null)
    {
      Errors = errors;
    }
    
    public IReadOnlyList<UserError> Errors { get; }
  }
}