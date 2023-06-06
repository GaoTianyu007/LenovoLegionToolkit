﻿using System.ComponentModel.DataAnnotations;
using LenovoLegionToolkit.Lib.Automation.Resources;

namespace LenovoLegionToolkit.Lib.Automation;

public enum DeactivateGPUAutomationStepState
{
    [Display(ResourceType = typeof(Resource), Name = "DeactivateGPUAutomationStepState_KillApps")]
    KillApps,
    [Display(ResourceType = typeof(Resource), Name = "DeactivateGPUAutomationStepState_RestartGPU")]
    RestartGPU,
}

public enum OverclockDiscreteGPUAutomationStepState
{
    [Display(ResourceType = typeof(Resource), Name = "OverclockDiscreteGPUAutomationStepState_Off")]
    Off,
    [Display(ResourceType = typeof(Resource), Name = "OverclockDiscreteGPUAutomationStepState_On")]
    On
}
