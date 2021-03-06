using System.Threading.Tasks;

namespace GitVersion.Command
{
    public abstract class CommandHandler<T> : ICommandHandler
        where T : GitVersionCommand
    {
        public abstract Task<int> InvokeAsync(T command);
        Task<int> ICommandHandler.InvokeAsync(object command) => InvokeAsync((T) command);
    }
}