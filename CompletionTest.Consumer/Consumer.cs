namespace CompletionTest.Consumer;
public class Consumer {
    public Consumer(TestViewModel viewModel)
    {
        // Visual Studio did NOT give me auto-completion for the SG properties while coding this
        _ = viewModel.Id;
        viewModel.DoSomethingCommand.Execute(default);
    }
}
