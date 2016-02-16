﻿using robotlegs.bender.extensions.eventDispatcher.impl;

namespace helloworld.events
{
	public class MessageEvent : Event
	{
		public enum Type
		{
			SEND
		}

		public string Message { get; private set; }

		public MessageEvent (MessageEvent.Type type, string message) : base(type) 
		{
			Message = message;
		}
	}
}