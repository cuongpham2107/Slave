using System;

namespace Slave
{
    public interface BaseState
    {        
        void Execute(Context context);
    }
}