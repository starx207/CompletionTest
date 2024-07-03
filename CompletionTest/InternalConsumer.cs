namespace CompletionTest;
internal class InternalConsumer {
    public InternalConsumer(TestViewModel viewModel)
    {
        // Visual Studio gave me auto-completion for the SG properties while coding this
        _ = viewModel.Id;
        viewModel.DoSomethingCommand.Execute(default);
    }
}
