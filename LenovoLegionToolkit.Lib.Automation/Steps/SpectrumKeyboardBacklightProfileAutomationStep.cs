﻿using System;
using System.Linq;
using System.Threading.Tasks;
using LenovoLegionToolkit.Lib.Controllers;
using Newtonsoft.Json;

namespace LenovoLegionToolkit.Lib.Automation.Steps;

public class SpectrumKeyboardBacklightProfileAutomationStep : IAutomationStep<int>
{
    private readonly SpectrumKeyboardBacklightController _controller = IoCContainer.Resolve<SpectrumKeyboardBacklightController>();

    private readonly int[] _allStates = Enumerable.Range(1, 6).ToArray();

    public int State { get; }

    [JsonConstructor]
    public SpectrumKeyboardBacklightProfileAutomationStep(int state) => State = state;

    public Task<int[]> GetAllStatesAsync() => Task.FromResult(_allStates);

    public Task<bool> IsSupportedAsync() => _controller.IsSupportedAsync();

    public async Task RunAsync(AutomationEnvironment _)
    {
        if (!await _controller.IsSupportedAsync().ConfigureAwait(false))
            return;

        if (!_allStates.Contains(State))
            throw new InvalidOperationException(nameof(State));

        await _controller.SetProfileAsync(State).ConfigureAwait(false);
    }

    public IAutomationStep DeepCopy() => new SpectrumKeyboardBacklightProfileAutomationStep(State);
}
