﻿using statsd.net.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace statsd.net_Tests.Infrastructure
{
  public class InAppBackend : ITargetBlock<GraphiteLine>
  {
    public DataflowMessageStatus OfferMessage(DataflowMessageHeader messageHeader, GraphiteLine messageValue, ISourceBlock<GraphiteLine> source, bool consumeToAccept)
    {
      throw new NotImplementedException();
    }

    public void Complete()
    {
      throw new NotImplementedException();
    }

    public Task Completion
    {
      get { throw new NotImplementedException(); }
    }

    public void Fault(Exception exception)
    {
      throw new NotImplementedException();
    }
  }
}