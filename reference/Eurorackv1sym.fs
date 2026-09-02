FeatureScript 3070;
import(path : "onshape/std/geometry.fs", version : "3070.0");

annotation { "Default Units" : ["cubicMillimeter", "degree", "degreePerSecond", "footPoundForce", "gram", "gramPerCubicCentimeter", "hertz", "inchPound", "meterPerSecondSquared", "millimeter", "poundForce", "poundPerSquareInch", "second", "squareMillimeter"] }
export function main()
{
    return build({ "RearHeight" : { 'value' : try(30 * millimeter), 'expression' : "30 mm" }.value, "List_sltuiwY7bs5tJx" : List_sltuiwY7bs5tJx_conf.Default, "HP_Count0" : { 'value' : try(26), 'expression' : "26" }.value, "Front_Height" : { 'value' : try(30 * millimeter), 'expression' : "30 mm" }.value, "List_5KGcbwyvF0AOZo" : List_5KGcbwyvF0AOZo_conf.Default, "Lower_Round" : { 'value' : try(1 * millimeter), 'expression' : "1 mm" }.value, "Upper_Round" : { 'value' : try(1 * millimeter), 'expression' : "1 mm" }.value, "Lower_Lip_Bevel" : { 'value' : try(1 * millimeter), 'expression' : "1 mm" }.value, "Upper_Chamfer" : { 'value' : try(1 * millimeter), 'expression' : "1 mm" }.value });
}

export function build()
{
    return buildPrivate({});
}

export function build(configuration is map)
{
    return buildPrivate(configuration);
}

export enum List_sltuiwY7bs5tJx_conf
{
    annotation { 'Name' : "Round" }
    Default,
    annotation { 'Name' : "Sharp" }
    Round,
    annotation { 'Name' : "Chamfer" }
    Bevel
}

export enum List_5KGcbwyvF0AOZo_conf
{
    annotation { 'Name' : "Round" }
    Default,
    annotation { 'Name' : "Sharp" }
    Sharp,
    annotation { 'Name' : "Chamfer" }
    Bevel
}

const buildPrivate = definePartStudio(function(context is Context, configuration is map, lookup is function)
    precondition
    {
        annotation { 'Name' : "HP_Count" }
        isInteger(configuration["HP_Count0"], { (unitless) : [2.0, 26.0, 200.0] } as IntegerBoundSpec);
        annotation { 'Name' : "Front Height" }
        isLength(configuration["Front_Height"], { (millimeter) : [15.0, 30.0, 200.0] } as LengthBoundSpec);
        annotation { 'Name' : "Rear Height" }
        isLength(configuration["RearHeight"], { (millimeter) : [30.0, 30.0, 150.0] } as LengthBoundSpec);
        annotation { 'Name' : "Top Lips" }
        configuration["List_sltuiwY7bs5tJx"] is List_sltuiwY7bs5tJx_conf;
        annotation { 'Name' : "Upper Round" }
        isLength(configuration["Upper_Round"], { (millimeter) : [0.5, 1.0, 10.0] } as LengthBoundSpec);
        annotation { 'Name' : "Upper Chamfer" }
        isLength(configuration["Upper_Chamfer"], { (millimeter) : [0.5, 1.0, 10.0] } as LengthBoundSpec);
        annotation { 'Name' : "Bottom Lips" }
        configuration["List_5KGcbwyvF0AOZo"] is List_5KGcbwyvF0AOZo_conf;
        annotation { 'Name' : "Lower Round" }
        isLength(configuration["Lower_Round"], { (millimeter) : [0.5, 1.0, 15.0] } as LengthBoundSpec);
        annotation { 'Name' : "Lower Chamfer" }
        isLength(configuration["Lower_Lip_Bevel"], { (millimeter) : [0.5, 1.0, 10.0] } as LengthBoundSpec);
    }
    {
        const id is Id = newId();
        annotation { 'unused' : true }
        var features = {};
        features.FRoOT5jGJl3VReg = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FRoOT5jGJl3VReg", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.NUMBER, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "HP_Count", "lengthValue" : 0.0 * meter, "angleValue" : 0.0 * degree, "numberValue" : { 'value' : try(lookup('HP_Count0')), 'expression' : "#HP_Count0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(lookup('HP_Count0')), 'expression' : "#HP_Count0" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FRoOT5jGJl3VReg(id));
        features.FW3jFisjC2YE795 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FW3jFisjC2YE795", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "RearHoleSpacing", "lengthValue" : { 'value' : try(23 * millimeter), 'expression' : "23 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(23 * millimeter), 'expression' : "23 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FW3jFisjC2YE795(id));
        features.FEqgCE5iUVIxdvc = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FEqgCE5iUVIxdvc", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "BottomHoleInset", "lengthValue" : { 'value' : try(4 * millimeter), 'expression' : "4 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(4 * millimeter), 'expression' : "4 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FEqgCE5iUVIxdvc(id));
        features.FTQNdgy9jgIMLdo = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FTQNdgy9jgIMLdo", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "BoltCounterboreThick", "lengthValue" : { 'value' : try(1.75 * millimeter), 'expression' : "1.75 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(1.75 * millimeter), 'expression' : "1.75 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FTQNdgy9jgIMLdo(id));
        features.FwL3GzGCHTUT30F = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FwL3GzGCHTUT30F", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "BoltCounterboreDiam", "lengthValue" : { 'value' : try(6 * millimeter), 'expression' : "6 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(6 * millimeter), 'expression' : "6 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FwL3GzGCHTUT30F(id));
        features.FM3c8sTX82i0uxu = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FM3c8sTX82i0uxu", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "HP", "lengthValue" : { 'value' : try(5.08 * millimeter), 'expression' : "5.08 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(5.08 * millimeter), 'expression' : "5.08 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FM3c8sTX82i0uxu(id));
        features.FbR0ga31D3pmfbP_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FbR0ga31D3pmfbP_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "RailBlockDepth", "lengthValue" : { 'value' : try(8 * millimeter), 'expression' : "8 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(8 * millimeter), 'expression' : "8 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FbR0ga31D3pmfbP_0(id));
        features.F3Xdg2RW9llKk4a_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "F3Xdg2RW9llKk4a_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "RailBlockHeight", "lengthValue" : { 'value' : try(16 * millimeter), 'expression' : "16 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(16 * millimeter), 'expression' : "16 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F3Xdg2RW9llKk4a_0(id));
        features.FVqP0RU1qSyQVGc_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FVqP0RU1qSyQVGc_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "RailBlockNutThickness", "lengthValue" : { 'value' : try(2.5 * millimeter), 'expression' : "2.5 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(2.5 * millimeter), 'expression' : "2.5 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FVqP0RU1qSyQVGc_0(id));
        features.FM6HVkTmTep80Yn_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FM6HVkTmTep80Yn_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "RailBlockNutWidth", "lengthValue" : { 'value' : try(5.8 * millimeter), 'expression' : "5.8 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(5.8 * millimeter), 'expression' : "5.8 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FM6HVkTmTep80Yn_0(id));
        features.FRLsXz7k83xTIDr_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FRLsXz7k83xTIDr_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "RailBlockBoltWidth", "lengthValue" : { 'value' : try(3.2 * millimeter), 'expression' : "3.2mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(3.2 * millimeter), 'expression' : "3.2mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FRLsXz7k83xTIDr_0(id));
        features.FOVFriezOLNH1cO_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FOVFriezOLNH1cO_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "RailBlockNutDepth", "lengthValue" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FOVFriezOLNH1cO_0(id));
        features.FHOsJaFKPkUOHA5_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FHOsJaFKPkUOHA5_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "RailBlockBoltDepth", "lengthValue" : { 'value' : try(8 * millimeter), 'expression' : "8 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(8 * millimeter), 'expression' : "8 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FHOsJaFKPkUOHA5_0(id));
        features.FnpUtB5upVjR8BF_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FnpUtB5upVjR8BF_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "RailBlockPanelInset", "lengthValue" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FnpUtB5upVjR8BF_0(id));
        features.Fk9ZNo3D2PFCQYa = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "Fk9ZNo3D2PFCQYa", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "BoltPlane_PanelEnd", "lengthValue" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.Fk9ZNo3D2PFCQYa(id));
        features.FqxxOJDSL5JQs8y_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FqxxOJDSL5JQs8y_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "CaseBottomThickness", "lengthValue" : { 'value' : try(4 * millimeter), 'expression' : "4 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(4 * millimeter), 'expression' : "4 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FqxxOJDSL5JQs8y_0(id));
        features.FwyD4PvpEbCnOVH_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FwyD4PvpEbCnOVH_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "CaseFrontBackThickness", "lengthValue" : { 'value' : try(4 * millimeter), 'expression' : "4 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(4 * millimeter), 'expression' : "4 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FwyD4PvpEbCnOVH_0(id));
        features.FnAAajrEIyZEehK_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FnAAajrEIyZEehK_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "CaseRearHeight", "lengthValue" : { 'value' : try(lookup('RearHeight')), 'expression' : "#RearHeight" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(lookup('RearHeight')), 'expression' : "#RearHeight" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FnAAajrEIyZEehK_0(id));
        features.F2bYCrTk4AWmRUk_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "F2bYCrTk4AWmRUk_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "CaseFrontHeight", "lengthValue" : { 'value' : try(33 * millimeter), 'expression' : "33 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(33 * millimeter), 'expression' : "33 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F2bYCrTk4AWmRUk_0(id));
        features.FQAuSLpaOSg0hFM_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FQAuSLpaOSg0hFM_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "PanelHeight", "lengthValue" : { 'value' : try(129.5 * millimeter), 'expression' : "129.5 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(129.5 * millimeter), 'expression' : "129.5 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FQAuSLpaOSg0hFM_0(id));
        features.FfncweduAogOfly_1 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FfncweduAogOfly_1", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "Rail_Length", "lengthValue" : { 'value' : try(56 * millimeter), 'expression' : "56 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(56 * millimeter), 'expression' : "56 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FfncweduAogOfly_1(id));
        features.FhPjAQNR5MZTId2_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FhPjAQNR5MZTId2_0", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "Railbolt_to_railbolt", "lengthValue" : { 'value' : try(123 * millimeter), 'expression' : "123 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(123 * millimeter), 'expression' : "123 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FhPjAQNR5MZTId2_0(id));
        features.FimVg8P8kETx6fg_3 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FimVg8P8kETx6fg_3", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "PanelThickness", "lengthValue" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FimVg8P8kETx6fg_3(id));
        features.F5hju5tHVOGakVf_3 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "F5hju5tHVOGakVf_3", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "PanelHoleVerticalInset", "lengthValue" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F5hju5tHVOGakVf_3(id));
        features.F3HD5PxY3AAr9PG_3 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessF3HD5PxY3AAr9PG_3 = { "7b7PflQGYaBO.bottom" : [-0.01496865414083004, 0.11444736546277999, 1.0, 4.930380657631324E-32, -0.08199946953654286, 0.04650053046345713], "7b7PflQGYaBO.top" : [-0.03847297177314757, 0.11244736546278, 1.0, 0.0, -0.05849515190422533, 0.07000484809577466], "7b7PflQGYaBO.left" : [-0.0969681236773729, 0.1161697618663311, 6.123233995736765E-17, -1.0, 0.0017223964035511102, 0.003722396403551098], "7b7PflQGYaBO.right" : [0.03153187632262709, 0.1161697618663311, 6.123233995736785E-17, -1.0, 0.0017223964035511102, 0.003722396403551098], "SH65Z0d1AWCe" : [0.027154864427447356, 0.11877333372831375, -1.0, -1.224646799147353E-16, -0.004377011895179736, -0.0013770118951797333], "1ys8Lj9eR4qr" : [0.02853187632262709, 0.11590329557657242, 6.123233995736765E-17, -1.0, -0.002870038151741333, 0.023669995367527008], "9wj5knCxnqaC" : [0.031836245970428015, 0.11720992624759674, 1.0, 0.0, -0.006204369647800925, -4.043696478009465E-4], "zwonuxSKhJrW" : [0.02853187632262709, 0.11720992624759674], "qV31vRAWK9Jp.bottom" : [0.027878963318467197, 0.10794736546278001, -1.0, -1.2246467991473532E-16, -0.0034513854354619386, 0.00214555942714215], "qV31vRAWK9Jp.top" : [0.0278726882427931, 0.11044736546278001, -1.0, -1.2246467991473535E-16, -0.003457660511136027, 0.0021392843514680543], "qV31vRAWK9Jp.left" : [0.03133034875392913, 0.10882494699954988, -1.8369701987210302E-16, 1.0, -8.775815367698669E-4, 0.0016224184632301353], "qV31vRAWK9Jp.right" : [0.025733403891325047, 0.10882494699954988, -1.8369701987210302E-16, 1.0, -8.775815367698669E-4, 0.0016224184632301353], "qV31vRAWK9Jp.middle" : [0.02853187632262709, 0.10919736546278001], "H0H1IgQBXohq.bottom" : [0.0278726882427931, 0.11244736546277999, 1.0, -2.449293598294707E-16, -9.40811920166016E-4, 0.0022591880798339854], "H0H1IgQBXohq.top" : [0.027872688242793098, 0.10444736546277998, 1.0, -2.449293598294707E-16, -9.408119201660195E-4, 0.0022591880798339854], "H0H1IgQBXohq.left" : [0.02693187632262708, 0.11040549385547606, -4.286263797015736E-16, -1.0, -0.002041871607303944, 0.005958128392696077], "H0H1IgQBXohq.right" : [0.030131876322627083, 0.11040549385547606, -4.286263797015736E-16, -1.0, -0.00204187160730393, 0.005958128392696077], "H0H1IgQBXohq.middle" : [0.028531876322627086, 0.10844736546277998], "sM9vLHW55aIC.bottom" : [0.027570002987980898, 0.11244736546278, -1.0, 1.2246467991473535E-16, -0.003961873334646194, 0.003836599096655853], "sM9vLHW55aIC.top" : [0.02637690106630334, 0.10244736546277998, -1.0, 1.2246467991473535E-16, -0.00515497525632376, 0.0026434971749782904], "sM9vLHW55aIC.left" : [0.0315318763226271, 0.10727094885706902, 3.0616169978683826E-16, -1.0, -0.0051764166057109845, 0.004823583394289038], "sM9vLHW55aIC.right" : [0.02373340389132505, 0.10602094885706903, 3.0616169978683826E-16, -1.0, -0.006426416605710972, 0.003573583394289051], "NLLPCQWM779r" : [-0.0327181236773729, 0.11444736546277999], "zpl25gy35apF" : [-0.0327181236773729, 0.11732187572121618, 0.0, 1.0, -0.002874510258436186, 0.0028745102584362137], "2zhSP29MB5C0" : [0.026931876322627085, 0.11394736546277999, -4.286263797015736E-16, -1.0, 0.0014999999999999875, 0.0034999999999999754], "jRJgF4jn1xRb" : [0.025679727102816144, 0.11044736546278001, -1.0, -1.2246467991473535E-16, -0.0012521492198109413, -5.3676788508903034E-5], "M393UcTfAOiu" : [0.02567972710281614, 0.10794736546278001, 1.0, 0.0, 5.36767885089065E-5, 0.0012521492198109413], "ia7uBLDka6Vf" : [0.02693187632262708, 0.10744736546277998, -4.286263797015736E-16, -1.0, -5.000000000000282E-4, 0.0030000000000000027], "BuzS0J2fMW1R" : [0.030131876322627083, 0.10744736546277998, 3.0616169978683826E-16, 1.0, -0.0030000000000000027, 5.000000000000282E-4], "GYkIcivTHZh0" : [0.03007819953411821, 0.10794736546278001, 1.0, 2.4492935982947064E-16, 5.367678850887181E-5, 0.001252149219810924], "we1zi02t9gOW" : [0.030078199534118215, 0.11044736546278001, -1.0, -1.2246467991473535E-16, -0.0012521492198109135, -5.367678850887181E-5], "cvmz9g6qzSM6" : [0.030131876322627087, 0.11394736546277999, 3.0616169978683826E-16, 1.0, -0.0034999999999999754, -0.0015000000000000013], "ky4nhU1YcMZQ" : [0.03133034875392913, 0.10919736546278001, -1.8369701987210302E-16, 1.0, -0.0012500000000000011, 0.0012500000000000011], "h9imJupVHxJe" : [0.025733403891325047, 0.10919736546278001, 3.0616169978683836E-16, -1.0, -0.0012500000000000011, 0.0012500000000000011], "Sd3UYAlmgizS" : [0.02787896331846715, 0.10444736546278, 1.0, -2.449293598294707E-16, -9.470869958400734E-4, 0.0022529130041599316], "IAhQH5pdcXoa0.MirrorCS" : [-0.08916965124607085, 0.10727094885706902, -3.061616997868382E-16, -1.0, -0.0051764166057109845, 0.004823583394289038], "c1csI3HDU9Q40.MirrorCS" : [-0.09371207635104654, 0.11244736546278, 1.0, 1.2246467991473535E-16, -0.0032560473263263667, 0.004542425104975684], "3B4XhxIS6baO0.MirrorCS" : [-0.09236812367737289, 0.11269736546278, 4.286263797015736E-16, -1.0, 2.500000000000002E-4, 0.002249999999999988], "e8qg0xJuDRdz0.MirrorCS" : [-0.09182180046588179, 0.11044736546278001, 1.0, -1.2246467991473535E-16, -5.463232114911037E-4, 6.521492198109241E-4], "JtOwtD4TvH0m0.MirrorCS" : [-0.09116965124607086, 0.11044736546278, -3.061616997868384E-16, -1.0, -1.3877787807814457E-17, 0.0024999999999999883], "Hp0vVPEzRmvH0.MirrorCS" : [-0.09182180046588179, 0.10794736546278001, -1.0, 0.0, -6.521492198109241E-4, 5.463232114910899E-4], "ZIrMrxSzcxLU0.MirrorCS" : [-0.09236812367737288, 0.10619736546278, 4.286263797015736E-16, -1.0, -0.0017500000000000154, 0.0017500000000000154], "tYz5EvXx9jyW0.MirrorCS" : [-0.0940210366815328, 0.10444736546278, -1.0, -2.449293598294707E-16, -0.0016529130041599283, 0.001547086995840094], "EHjnTiSpAmov0.MirrorCS" : [-0.0955681236773729, 0.10619736546278, -3.0616169978683826E-16, 1.0, -0.0017500000000000154, 0.0017500000000000154], "eNPiNw1YnKe30.MirrorCS" : [-0.09622027289718385, 0.10794736546278001, -1.0, 2.4492935982947064E-16, -6.521492198109519E-4, 5.463232114911037E-4], "KLN7QBv8sX7X0.MirrorCS" : [-0.09676659610867494, 0.11044736546278, 1.8369701987210304E-16, 1.0, -0.0024999999999999883, 1.3877787807814457E-17], "YX2cwJO9Q5H60.MirrorCS" : [-0.09622027289718385, 0.11044736546278001, 1.0, -1.2246467991473535E-16, -5.463232114910899E-4, 6.521492198109657E-4], "ix8OSQrkGxeR0.MirrorCS" : [-0.09556812367737288, 0.11269736546278, -3.0616169978683826E-16, 1.0, -0.002249999999999988, -2.500000000000141E-4], "LhC2jMEYbjYG0.MirrorCS" : [-0.09251897442936899, 0.10244736546277998, 1.0, 1.2246467991473535E-16, -0.0044491492480039085, 0.003349323183298142], "9mwv8ZyL37Ap0.MirrorCS" : [-0.0969681236773729, 0.10727094885706902, -3.0616169978683826E-16, -1.0, -0.0051764166057109845, 0.004823583394289038] };
                    {
                    }
                    var UpHcILQOCJDMoQ_query;
                    UpHcILQOCJDMoQ_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S5.7$RightplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Rail block profile" }
                    var sketch = newSketch(context, id + "F3HD5PxY3AAr9PG_3", { "sketchPlane" : qUnion([UpHcILQOCJDMoQ_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "7b7PflQGYaBO.bottom", { "construction" : true, "index" : "3" });
                    skLineSegment(sketch, "7b7PflQGYaBO.top", { "construction" : true, "index" : "4" });
                    skLineSegment(sketch, "7b7PflQGYaBO.left", { "construction" : true, "index" : "5" });
                    skLineSegment(sketch, "7b7PflQGYaBO.right", { "construction" : true, "index" : "6" });
                    skLineSegment(sketch, "SH65Z0d1AWCe", { "construction" : true, "index" : "7" });
                    skLineSegment(sketch, "1ys8Lj9eR4qr", { "construction" : true, "index" : "8" });
                    skLineSegment(sketch, "9wj5knCxnqaC", { "construction" : true, "index" : "9" });
                    skPoint(sketch, "zwonuxSKhJrW", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "qV31vRAWK9Jp.bottom", { "construction" : true, "index" : "10" });
                    skLineSegment(sketch, "qV31vRAWK9Jp.top", { "construction" : true, "index" : "11" });
                    skLineSegment(sketch, "qV31vRAWK9Jp.left", { "construction" : true, "index" : "12" });
                    skLineSegment(sketch, "qV31vRAWK9Jp.right", { "construction" : true, "index" : "13" });
                    skPoint(sketch, "qV31vRAWK9Jp.middle", { "construction" : true, "index" : "2" });
                    skLineSegment(sketch, "H0H1IgQBXohq.bottom", { "construction" : true, "index" : "14" });
                    skLineSegment(sketch, "H0H1IgQBXohq.top", { "construction" : true, "index" : "15" });
                    skLineSegment(sketch, "H0H1IgQBXohq.left", { "construction" : true, "index" : "16" });
                    skLineSegment(sketch, "H0H1IgQBXohq.right", { "construction" : true, "index" : "17" });
                    skPoint(sketch, "H0H1IgQBXohq.middle", { "construction" : true, "index" : "3" });
                    skLineSegment(sketch, "sM9vLHW55aIC.bottom", { "construction" : false, "index" : "18" });
                    skLineSegment(sketch, "sM9vLHW55aIC.top", { "construction" : false, "index" : "19" });
                    skLineSegment(sketch, "sM9vLHW55aIC.left", { "construction" : false, "index" : "20" });
                    skLineSegment(sketch, "sM9vLHW55aIC.right", { "construction" : false, "index" : "21" });
                    skPoint(sketch, "NLLPCQWM779r", { "construction" : false, "index" : "4" });
                    skLineSegment(sketch, "zpl25gy35apF", { "construction" : true, "index" : "22" });
                    skLineSegment(sketch, "2zhSP29MB5C0", { "construction" : false, "index" : "23" });
                    skLineSegment(sketch, "jRJgF4jn1xRb", { "construction" : false, "index" : "24" });
                    skLineSegment(sketch, "M393UcTfAOiu", { "construction" : false, "index" : "25" });
                    skLineSegment(sketch, "ia7uBLDka6Vf", { "construction" : false, "index" : "26" });
                    skLineSegment(sketch, "BuzS0J2fMW1R", { "construction" : false, "index" : "27" });
                    skLineSegment(sketch, "GYkIcivTHZh0", { "construction" : false, "index" : "28" });
                    skLineSegment(sketch, "we1zi02t9gOW", { "construction" : false, "index" : "29" });
                    skLineSegment(sketch, "cvmz9g6qzSM6", { "construction" : false, "index" : "30" });
                    skLineSegment(sketch, "ky4nhU1YcMZQ", { "construction" : false, "index" : "31" });
                    skLineSegment(sketch, "h9imJupVHxJe", { "construction" : false, "index" : "32" });
                    skLineSegment(sketch, "Sd3UYAlmgizS", { "construction" : false, "index" : "33" });
                    skLineSegment(sketch, "IAhQH5pdcXoa0.MirrorCS", { "construction" : false, "index" : "34" });
                    skLineSegment(sketch, "c1csI3HDU9Q40.MirrorCS", { "construction" : false, "index" : "35" });
                    skLineSegment(sketch, "3B4XhxIS6baO0.MirrorCS", { "construction" : false, "index" : "36" });
                    skLineSegment(sketch, "e8qg0xJuDRdz0.MirrorCS", { "construction" : false, "index" : "37" });
                    skLineSegment(sketch, "JtOwtD4TvH0m0.MirrorCS", { "construction" : false, "index" : "38" });
                    skLineSegment(sketch, "Hp0vVPEzRmvH0.MirrorCS", { "construction" : false, "index" : "39" });
                    skLineSegment(sketch, "ZIrMrxSzcxLU0.MirrorCS", { "construction" : false, "index" : "40" });
                    skLineSegment(sketch, "tYz5EvXx9jyW0.MirrorCS", { "construction" : false, "index" : "41" });
                    skLineSegment(sketch, "EHjnTiSpAmov0.MirrorCS", { "construction" : false, "index" : "42" });
                    skLineSegment(sketch, "eNPiNw1YnKe30.MirrorCS", { "construction" : false, "index" : "43" });
                    skLineSegment(sketch, "KLN7QBv8sX7X0.MirrorCS", { "construction" : false, "index" : "44" });
                    skLineSegment(sketch, "YX2cwJO9Q5H60.MirrorCS", { "construction" : false, "index" : "45" });
                    skLineSegment(sketch, "ix8OSQrkGxeR0.MirrorCS", { "construction" : false, "index" : "46" });
                    skLineSegment(sketch, "LhC2jMEYbjYG0.MirrorCS", { "construction" : false, "index" : "47" });
                    skLineSegment(sketch, "9mwv8ZyL37Ap0.MirrorCS", { "construction" : false, "index" : "48" });
                    {
                        skConstraint(sketch, "7b7PflQGYaBO.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "7b7PflQGYaBO.top", "localSecond" : "7b7PflQGYaBO.left" });
                    }
                    {
                        skConstraint(sketch, "7b7PflQGYaBO.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "7b7PflQGYaBO.bottom", "localSecond" : "7b7PflQGYaBO.top" });
                    }
                    {
                        skConstraint(sketch, "7b7PflQGYaBO.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "7b7PflQGYaBO.left", "localSecond" : "7b7PflQGYaBO.right" });
                    }
                    {
                        skConstraint(sketch, "7b7PflQGYaBO.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "2", "name" : "", "localFirst" : "7b7PflQGYaBO.top" });
                    }
                    {
                        skConstraint(sketch, "7b7PflQGYaBO.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "7b7PflQGYaBO.bottom.start", "localSecond" : "7b7PflQGYaBO.left.start" });
                    }
                    {
                        skConstraint(sketch, "7b7PflQGYaBO.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "7b7PflQGYaBO.bottom.end", "localSecond" : "7b7PflQGYaBO.right.start" });
                    }
                    {
                        skConstraint(sketch, "7b7PflQGYaBO.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "7b7PflQGYaBO.top.start", "localSecond" : "7b7PflQGYaBO.left.end" });
                    }
                    {
                        skConstraint(sketch, "7b7PflQGYaBO.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "7b7PflQGYaBO.top.end", "localSecond" : "7b7PflQGYaBO.right.end" });
                    }
                    {
                        skConstraint(sketch, "IM9ivfeNS0SA", { "constraintType" : ConstraintType.LENGTH, "index" : "3", "name" : "", "localFirst" : "7b7PflQGYaBO.bottom", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('PanelHeight')), 'expression' : "#PanelHeight" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.8378204380819503, "labelDistance" : -0.006519973278045635 * meter });
                    }
                    {
                        skConstraint(sketch, "NhdOQJhY3wjG", { "constraintType" : ConstraintType.LENGTH, "index" : "4", "name" : "", "localFirst" : "7b7PflQGYaBO.right", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('PanelThickness')), 'expression' : "#PanelThickness" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : -4.111759368401414, "labelDistance" : -0.015939904868602764 * meter });
                    }
                    {
                        skConstraint(sketch, "SH65Z0d1AWCe.startSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "name" : "", "localFirst" : "SH65Z0d1AWCe.start", "localSecond" : "7b7PflQGYaBO.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "SH65Z0d1AWCe.endSnap0", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "3", "name" : "", "localFirst" : "SH65Z0d1AWCe" });
                    }
                    {
                        skConstraint(sketch, "FE6FEryfHzVC", { "constraintType" : ConstraintType.LENGTH, "index" : "5", "name" : "", "localFirst" : "SH65Z0d1AWCe", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('PanelHoleVerticalInset')), 'expression' : "#PanelHoleVerticalInset" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : -4.719848205645874, "labelDistance" : -0.010350549955785326 * meter });
                    }
                    {
                        skConstraint(sketch, "1ys8Lj9eR4qr.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "1ys8Lj9eR4qr.start", "localSecond" : "SH65Z0d1AWCe.end" });
                    }
                    {
                        skConstraint(sketch, "1ys8Lj9eR4qr.endSnap0", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "2", "name" : "", "localFirst" : "1ys8Lj9eR4qr", "localSecond" : "7b7PflQGYaBO.top" });
                    }
                    {
                        skConstraint(sketch, "9wj5knCxnqaC.endSnap0", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "4", "name" : "", "localFirst" : "9wj5knCxnqaC" });
                    }
                    {
                        skConstraint(sketch, "MelBzT8I8Jdx", { "constraintType" : ConstraintType.LENGTH, "index" : "6", "name" : "", "localFirst" : "9wj5knCxnqaC", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('RailBlockNutWidth')), 'expression' : "#RailBlockNutWidth" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : -2.3243053405744516, "labelDistance" : 0.019832715392112732 * meter });
                    }
                    {
                        skConstraint(sketch, "zwonuxSKhJrW.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localEntity1" : "zwonuxSKhJrW", "localEntity2" : "9wj5knCxnqaC" });
                    }
                    {
                        skConstraint(sketch, "dQgIfHto5PxD", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "name" : "", "localFirst" : "zwonuxSKhJrW", "localSecond" : "1ys8Lj9eR4qr" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "2", "name" : "", "localMidpoint" : "qV31vRAWK9Jp.middle", "localEntity1" : "qV31vRAWK9Jp.top.start", "localEntity2" : "qV31vRAWK9Jp.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.mid2", { "constraintType" : ConstraintType.MIDPOINT, "index" : "3", "name" : "", "localMidpoint" : "qV31vRAWK9Jp.middle", "localEntity1" : "qV31vRAWK9Jp.top.end", "localEntity2" : "qV31vRAWK9Jp.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "3", "name" : "", "localFirst" : "qV31vRAWK9Jp.top", "localSecond" : "qV31vRAWK9Jp.left" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "3", "name" : "", "localFirst" : "qV31vRAWK9Jp.bottom", "localSecond" : "qV31vRAWK9Jp.top" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "4", "name" : "", "localFirst" : "qV31vRAWK9Jp.left", "localSecond" : "qV31vRAWK9Jp.right" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "5", "name" : "", "localFirst" : "qV31vRAWK9Jp.top" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "name" : "", "localFirst" : "qV31vRAWK9Jp.bottom.start", "localSecond" : "qV31vRAWK9Jp.left.start" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "9", "name" : "", "localFirst" : "qV31vRAWK9Jp.bottom.end", "localSecond" : "qV31vRAWK9Jp.right.start" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "10", "name" : "", "localFirst" : "qV31vRAWK9Jp.top.start", "localSecond" : "qV31vRAWK9Jp.left.end" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "11", "name" : "", "localFirst" : "qV31vRAWK9Jp.top.end", "localSecond" : "qV31vRAWK9Jp.right.end" });
                    }
                    {
                        skConstraint(sketch, "qV31vRAWK9Jp.middle.positionSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "12", "name" : "", "localFirst" : "qV31vRAWK9Jp.middle", "localSecond" : "1ys8Lj9eR4qr" });
                    }
                    {
                        skConstraint(sketch, "TdhSzk6Jxdyq", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "localFirst" : "qV31vRAWK9Jp.top", "localSecond" : "7b7PflQGYaBO.top", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('RailBlockNutDepth')), 'expression' : "#RailBlockNutDepth" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : -0.8540660761129909, "labelDistance" : 0.00957793080508709 * meter });
                    }
                    {
                        skConstraint(sketch, "nEiGNP1blKEV", { "constraintType" : ConstraintType.LENGTH, "index" : "7", "name" : "", "localFirst" : "qV31vRAWK9Jp.left", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('RailBlockNutThickness')), 'expression' : "#RailBlockNutThickness" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : -1.938625571208295, "labelDistance" : 0.004873018711805344 * meter });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "4", "name" : "", "localMidpoint" : "H0H1IgQBXohq.middle", "localEntity1" : "H0H1IgQBXohq.top.start", "localEntity2" : "H0H1IgQBXohq.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.mid2", { "constraintType" : ConstraintType.MIDPOINT, "index" : "5", "name" : "", "localMidpoint" : "H0H1IgQBXohq.middle", "localEntity1" : "H0H1IgQBXohq.top.end", "localEntity2" : "H0H1IgQBXohq.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "4", "name" : "", "localFirst" : "H0H1IgQBXohq.top", "localSecond" : "H0H1IgQBXohq.left" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "5", "name" : "", "localFirst" : "H0H1IgQBXohq.bottom", "localSecond" : "H0H1IgQBXohq.top" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "6", "name" : "", "localFirst" : "H0H1IgQBXohq.left", "localSecond" : "H0H1IgQBXohq.right" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "6", "name" : "", "localFirst" : "H0H1IgQBXohq.top" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "13", "name" : "", "localFirst" : "H0H1IgQBXohq.bottom.start", "localSecond" : "H0H1IgQBXohq.left.start" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "14", "name" : "", "localFirst" : "H0H1IgQBXohq.bottom.end", "localSecond" : "H0H1IgQBXohq.right.start" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "15", "name" : "", "localFirst" : "H0H1IgQBXohq.top.start", "localSecond" : "H0H1IgQBXohq.left.end" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "16", "name" : "", "localFirst" : "H0H1IgQBXohq.top.end", "localSecond" : "H0H1IgQBXohq.right.end" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.middle.positionSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "17", "name" : "", "localFirst" : "H0H1IgQBXohq.middle", "localSecond" : "1ys8Lj9eR4qr" });
                    }
                    {
                        skConstraint(sketch, "H0H1IgQBXohq.cornerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "18", "name" : "", "localFirst" : "H0H1IgQBXohq.bottom.start", "localSecond" : "7b7PflQGYaBO.top" });
                    }
                    {
                        skConstraint(sketch, "urg4f2EYo43q", { "constraintType" : ConstraintType.LENGTH, "index" : "8", "name" : "", "localFirst" : "H0H1IgQBXohq.right", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('RailBlockBoltDepth')), 'expression' : "#RailBlockBoltDepth" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.7839977155792105, "labelDistance" : -0.011287402161955836 * meter });
                    }
                    {
                        skConstraint(sketch, "NlsA7E0P1mqb", { "constraintType" : ConstraintType.LENGTH, "index" : "9", "name" : "", "localFirst" : "H0H1IgQBXohq.top", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('RailBlockBoltWidth')), 'expression' : "#RailBlockBoltWidth" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 2.6636735591688905, "labelDistance" : -9.604623317718552E-4 * meter });
                    }
                    {
                        skConstraint(sketch, "sM9vLHW55aIC.firstSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "19", "name" : "", "localFirst" : "sM9vLHW55aIC.bottom.start", "localSecond" : "7b7PflQGYaBO.top.end" });
                    }
                    {
                        skConstraint(sketch, "sM9vLHW55aIC.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "5", "name" : "", "localFirst" : "sM9vLHW55aIC.top", "localSecond" : "sM9vLHW55aIC.left" });
                    }
                    {
                        skConstraint(sketch, "sM9vLHW55aIC.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "7", "name" : "", "localFirst" : "sM9vLHW55aIC.bottom", "localSecond" : "sM9vLHW55aIC.top" });
                    }
                    {
                        skConstraint(sketch, "sM9vLHW55aIC.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "8", "name" : "", "localFirst" : "sM9vLHW55aIC.left", "localSecond" : "sM9vLHW55aIC.right" });
                    }
                    {
                        skConstraint(sketch, "sM9vLHW55aIC.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "7", "name" : "", "localFirst" : "sM9vLHW55aIC.top" });
                    }
                    {
                        skConstraint(sketch, "sM9vLHW55aIC.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "20", "name" : "", "localFirst" : "sM9vLHW55aIC.bottom.start", "localSecond" : "sM9vLHW55aIC.left.start" });
                    }
                    {
                        skConstraint(sketch, "sM9vLHW55aIC.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "21", "name" : "", "localFirst" : "sM9vLHW55aIC.bottom.end", "localSecond" : "sM9vLHW55aIC.right.start" });
                    }
                    {
                        skConstraint(sketch, "sM9vLHW55aIC.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "22", "name" : "", "localFirst" : "sM9vLHW55aIC.top.start", "localSecond" : "sM9vLHW55aIC.left.end" });
                    }
                    {
                        skConstraint(sketch, "sM9vLHW55aIC.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "23", "name" : "", "localFirst" : "sM9vLHW55aIC.top.end", "localSecond" : "sM9vLHW55aIC.right.end" });
                    }
                    {
                        skConstraint(sketch, "Sj2ykqmHZe7n", { "constraintType" : ConstraintType.DISTANCE, "index" : "2", "name" : "", "localFirst" : "qV31vRAWK9Jp.right", "localSecond" : "sM9vLHW55aIC.right", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.LEFT, "labelRatio" : 7.122664689866637, "labelDistance" : 0.004810388803482057 * meter });
                    }
                    {
                        skConstraint(sketch, "QtkV15eCdSE0", { "constraintType" : ConstraintType.DISTANCE, "index" : "3", "name" : "", "localFirst" : "H0H1IgQBXohq.top", "localSecond" : "sM9vLHW55aIC.top", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : 1.465214551019178, "labelDistance" : -0.011067808505892774 * meter });
                    }
                    {
                        skConstraint(sketch, "NLLPCQWM779r.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "6", "name" : "", "localEntity1" : "NLLPCQWM779r", "localEntity2" : "7b7PflQGYaBO.bottom" });
                    }
                    {
                        skConstraint(sketch, "zpl25gy35apF.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "24", "name" : "", "localFirst" : "zpl25gy35apF.start", "localSecond" : "NLLPCQWM779r" });
                    }
                    {
                        skConstraint(sketch, "zpl25gy35apF.endSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "2", "name" : "", "localFirst" : "zpl25gy35apF" });
                    }
                    {
                        skConstraint(sketch, "2zhSP29MB5C0.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "25", "name" : "", "localFirst" : "2zhSP29MB5C0.start", "localSecond" : "H0H1IgQBXohq.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "2zhSP29MB5C0.endSnap0", { "constraintType" : ConstraintType.PARALLEL, "index" : "9", "name" : "", "localFirst" : "2zhSP29MB5C0", "localSecond" : "H0H1IgQBXohq.left" });
                    }
                    {
                        skConstraint(sketch, "2zhSP29MB5C0.endSnap1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "26", "name" : "", "localFirst" : "2zhSP29MB5C0.end", "localSecond" : "qV31vRAWK9Jp.top" });
                    }
                    {
                        skConstraint(sketch, "jRJgF4jn1xRb.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "27", "name" : "", "localFirst" : "jRJgF4jn1xRb.start", "localSecond" : "2zhSP29MB5C0.end" });
                    }
                    {
                        skConstraint(sketch, "jRJgF4jn1xRb.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "28", "name" : "", "localFirst" : "jRJgF4jn1xRb.end", "localSecond" : "qV31vRAWK9Jp.top.end" });
                    }
                    {
                        skConstraint(sketch, "M393UcTfAOiu.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "29", "name" : "", "localFirst" : "M393UcTfAOiu.start", "localSecond" : "qV31vRAWK9Jp.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "M393UcTfAOiu.endSnap0", { "constraintType" : ConstraintType.PARALLEL, "index" : "10", "name" : "", "localFirst" : "M393UcTfAOiu", "localSecond" : "qV31vRAWK9Jp.bottom" });
                    }
                    {
                        skConstraint(sketch, "M393UcTfAOiu.endSnap1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "30", "name" : "", "localFirst" : "M393UcTfAOiu.end", "localSecond" : "H0H1IgQBXohq.left" });
                    }
                    {
                        skConstraint(sketch, "ia7uBLDka6Vf.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "31", "name" : "", "localFirst" : "ia7uBLDka6Vf.start", "localSecond" : "M393UcTfAOiu.end" });
                    }
                    {
                        skConstraint(sketch, "ia7uBLDka6Vf.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "32", "name" : "", "localFirst" : "ia7uBLDka6Vf.end", "localSecond" : "H0H1IgQBXohq.top.start" });
                    }
                    {
                        skConstraint(sketch, "BuzS0J2fMW1R.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "33", "name" : "", "localFirst" : "BuzS0J2fMW1R.start", "localSecond" : "H0H1IgQBXohq.top.end" });
                    }
                    {
                        skConstraint(sketch, "BuzS0J2fMW1R.endSnap0", { "constraintType" : ConstraintType.PARALLEL, "index" : "11", "name" : "", "localFirst" : "BuzS0J2fMW1R", "localSecond" : "H0H1IgQBXohq.right" });
                    }
                    {
                        skConstraint(sketch, "BuzS0J2fMW1R.endSnap1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "34", "name" : "", "localFirst" : "BuzS0J2fMW1R.end", "localSecond" : "qV31vRAWK9Jp.bottom" });
                    }
                    {
                        skConstraint(sketch, "GYkIcivTHZh0.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "35", "name" : "", "localFirst" : "GYkIcivTHZh0.start", "localSecond" : "BuzS0J2fMW1R.end" });
                    }
                    {
                        skConstraint(sketch, "GYkIcivTHZh0.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "36", "name" : "", "localFirst" : "GYkIcivTHZh0.end", "localSecond" : "qV31vRAWK9Jp.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "we1zi02t9gOW.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "37", "name" : "", "localFirst" : "we1zi02t9gOW.start", "localSecond" : "qV31vRAWK9Jp.top.start" });
                    }
                    {
                        skConstraint(sketch, "we1zi02t9gOW.endSnap0", { "constraintType" : ConstraintType.PARALLEL, "index" : "12", "name" : "", "localFirst" : "we1zi02t9gOW", "localSecond" : "qV31vRAWK9Jp.top" });
                    }
                    {
                        skConstraint(sketch, "we1zi02t9gOW.endSnap1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "38", "name" : "", "localFirst" : "we1zi02t9gOW.end", "localSecond" : "H0H1IgQBXohq.right" });
                    }
                    {
                        skConstraint(sketch, "cvmz9g6qzSM6.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "39", "name" : "", "localFirst" : "cvmz9g6qzSM6.start", "localSecond" : "we1zi02t9gOW.end" });
                    }
                    {
                        skConstraint(sketch, "cvmz9g6qzSM6.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "40", "name" : "", "localFirst" : "cvmz9g6qzSM6.end", "localSecond" : "H0H1IgQBXohq.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "ky4nhU1YcMZQ.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "41", "name" : "", "localFirst" : "ky4nhU1YcMZQ.start", "localSecond" : "qV31vRAWK9Jp.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "ky4nhU1YcMZQ.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "42", "name" : "", "localFirst" : "ky4nhU1YcMZQ.end", "localSecond" : "qV31vRAWK9Jp.top.start" });
                    }
                    {
                        skConstraint(sketch, "h9imJupVHxJe.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "43", "name" : "", "localFirst" : "h9imJupVHxJe.start", "localSecond" : "qV31vRAWK9Jp.top.end" });
                    }
                    {
                        skConstraint(sketch, "h9imJupVHxJe.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "44", "name" : "", "localFirst" : "h9imJupVHxJe.end", "localSecond" : "qV31vRAWK9Jp.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "Sd3UYAlmgizS.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "45", "name" : "", "localFirst" : "Sd3UYAlmgizS.start", "localSecond" : "H0H1IgQBXohq.top.start" });
                    }
                    {
                        skConstraint(sketch, "Sd3UYAlmgizS.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "46", "name" : "", "localFirst" : "Sd3UYAlmgizS.end", "localSecond" : "H0H1IgQBXohq.top.end" });
                    }
                    {
                        skConstraint(sketch, "IAhQH5pdcXoa0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "1", "name" : "", "localFirst" : "sM9vLHW55aIC.right", "localSecond" : "IAhQH5pdcXoa0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "IAhQH5pdcXoa0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "2", "name" : "", "localFirst" : "sM9vLHW55aIC.right.start", "localSecond" : "IAhQH5pdcXoa0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "IAhQH5pdcXoa0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "3", "name" : "", "localFirst" : "sM9vLHW55aIC.right.end", "localSecond" : "IAhQH5pdcXoa0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "c1csI3HDU9Q40.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "4", "name" : "", "localFirst" : "sM9vLHW55aIC.bottom", "localSecond" : "c1csI3HDU9Q40.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "c1csI3HDU9Q40.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "5", "name" : "", "localFirst" : "sM9vLHW55aIC.bottom.start", "localSecond" : "c1csI3HDU9Q40.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "c1csI3HDU9Q40.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "6", "name" : "", "localFirst" : "sM9vLHW55aIC.bottom.end", "localSecond" : "c1csI3HDU9Q40.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "3B4XhxIS6baO0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "7", "name" : "", "localFirst" : "2zhSP29MB5C0", "localSecond" : "3B4XhxIS6baO0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "3B4XhxIS6baO0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "8", "name" : "", "localFirst" : "2zhSP29MB5C0.start", "localSecond" : "3B4XhxIS6baO0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "3B4XhxIS6baO0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "9", "name" : "", "localFirst" : "2zhSP29MB5C0.end", "localSecond" : "3B4XhxIS6baO0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "e8qg0xJuDRdz0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "10", "name" : "", "localFirst" : "jRJgF4jn1xRb", "localSecond" : "e8qg0xJuDRdz0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "e8qg0xJuDRdz0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "11", "name" : "", "localFirst" : "jRJgF4jn1xRb.start", "localSecond" : "e8qg0xJuDRdz0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "e8qg0xJuDRdz0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "12", "name" : "", "localFirst" : "jRJgF4jn1xRb.end", "localSecond" : "e8qg0xJuDRdz0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "JtOwtD4TvH0m0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "13", "name" : "", "localFirst" : "h9imJupVHxJe", "localSecond" : "JtOwtD4TvH0m0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "JtOwtD4TvH0m0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "14", "name" : "", "localFirst" : "h9imJupVHxJe.start", "localSecond" : "JtOwtD4TvH0m0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "JtOwtD4TvH0m0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "15", "name" : "", "localFirst" : "h9imJupVHxJe.end", "localSecond" : "JtOwtD4TvH0m0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "Hp0vVPEzRmvH0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "16", "name" : "", "localFirst" : "M393UcTfAOiu", "localSecond" : "Hp0vVPEzRmvH0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "Hp0vVPEzRmvH0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "17", "name" : "", "localFirst" : "M393UcTfAOiu.start", "localSecond" : "Hp0vVPEzRmvH0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "Hp0vVPEzRmvH0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "18", "name" : "", "localFirst" : "M393UcTfAOiu.end", "localSecond" : "Hp0vVPEzRmvH0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "ZIrMrxSzcxLU0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "19", "name" : "", "localFirst" : "ia7uBLDka6Vf", "localSecond" : "ZIrMrxSzcxLU0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "ZIrMrxSzcxLU0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "20", "name" : "", "localFirst" : "ia7uBLDka6Vf.start", "localSecond" : "ZIrMrxSzcxLU0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "ZIrMrxSzcxLU0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "21", "name" : "", "localFirst" : "ia7uBLDka6Vf.end", "localSecond" : "ZIrMrxSzcxLU0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "tYz5EvXx9jyW0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "22", "name" : "", "localFirst" : "Sd3UYAlmgizS", "localSecond" : "tYz5EvXx9jyW0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "tYz5EvXx9jyW0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "23", "name" : "", "localFirst" : "Sd3UYAlmgizS.start", "localSecond" : "tYz5EvXx9jyW0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "tYz5EvXx9jyW0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "24", "name" : "", "localFirst" : "Sd3UYAlmgizS.end", "localSecond" : "tYz5EvXx9jyW0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "EHjnTiSpAmov0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "25", "name" : "", "localFirst" : "BuzS0J2fMW1R", "localSecond" : "EHjnTiSpAmov0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "EHjnTiSpAmov0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "26", "name" : "", "localFirst" : "BuzS0J2fMW1R.start", "localSecond" : "EHjnTiSpAmov0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "EHjnTiSpAmov0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "27", "name" : "", "localFirst" : "BuzS0J2fMW1R.end", "localSecond" : "EHjnTiSpAmov0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "eNPiNw1YnKe30.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "28", "name" : "", "localFirst" : "GYkIcivTHZh0", "localSecond" : "eNPiNw1YnKe30.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "eNPiNw1YnKe30.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "29", "name" : "", "localFirst" : "GYkIcivTHZh0.start", "localSecond" : "eNPiNw1YnKe30.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "eNPiNw1YnKe30.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "30", "name" : "", "localFirst" : "GYkIcivTHZh0.end", "localSecond" : "eNPiNw1YnKe30.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "KLN7QBv8sX7X0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "31", "name" : "", "localFirst" : "ky4nhU1YcMZQ", "localSecond" : "KLN7QBv8sX7X0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "KLN7QBv8sX7X0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "32", "name" : "", "localFirst" : "ky4nhU1YcMZQ.start", "localSecond" : "KLN7QBv8sX7X0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "KLN7QBv8sX7X0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "33", "name" : "", "localFirst" : "ky4nhU1YcMZQ.end", "localSecond" : "KLN7QBv8sX7X0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "YX2cwJO9Q5H60.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "34", "name" : "", "localFirst" : "we1zi02t9gOW", "localSecond" : "YX2cwJO9Q5H60.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "YX2cwJO9Q5H60.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "35", "name" : "", "localFirst" : "we1zi02t9gOW.start", "localSecond" : "YX2cwJO9Q5H60.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "YX2cwJO9Q5H60.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "36", "name" : "", "localFirst" : "we1zi02t9gOW.end", "localSecond" : "YX2cwJO9Q5H60.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "ix8OSQrkGxeR0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "37", "name" : "", "localFirst" : "cvmz9g6qzSM6", "localSecond" : "ix8OSQrkGxeR0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "ix8OSQrkGxeR0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "38", "name" : "", "localFirst" : "cvmz9g6qzSM6.start", "localSecond" : "ix8OSQrkGxeR0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "ix8OSQrkGxeR0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "39", "name" : "", "localFirst" : "cvmz9g6qzSM6.end", "localSecond" : "ix8OSQrkGxeR0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "LhC2jMEYbjYG0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "40", "name" : "", "localFirst" : "sM9vLHW55aIC.top", "localSecond" : "LhC2jMEYbjYG0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "LhC2jMEYbjYG0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "41", "name" : "", "localFirst" : "sM9vLHW55aIC.top.start", "localSecond" : "LhC2jMEYbjYG0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "LhC2jMEYbjYG0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "42", "name" : "", "localFirst" : "sM9vLHW55aIC.top.end", "localSecond" : "LhC2jMEYbjYG0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "9mwv8ZyL37Ap0.MirrorCS.cons", { "constraintType" : ConstraintType.MIRROR, "index" : "43", "name" : "", "localFirst" : "sM9vLHW55aIC.left", "localSecond" : "9mwv8ZyL37Ap0.MirrorCS", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "9mwv8ZyL37Ap0.MirrorCS.begCons", { "constraintType" : ConstraintType.MIRROR, "index" : "44", "name" : "", "localFirst" : "sM9vLHW55aIC.left.start", "localSecond" : "9mwv8ZyL37Ap0.MirrorCS.start", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "9mwv8ZyL37Ap0.MirrorCS.endCons", { "constraintType" : ConstraintType.MIRROR, "index" : "45", "name" : "", "localFirst" : "sM9vLHW55aIC.left.end", "localSecond" : "9mwv8ZyL37Ap0.MirrorCS.end", "localMirror" : "zpl25gy35apF", "sketchToolType" : SketchToolType.MIRROR });
                    }
                    {
                        skConstraint(sketch, "A7UWopYyjGhc", { "constraintType" : ConstraintType.LENGTH, "index" : "10", "name" : "", "localFirst" : "sM9vLHW55aIC.right", "direction" : DimensionDirection.MINIMUM, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 1.2666165173053714, "labelDistance" : 0.004324252143502288 * meter, "driven" : true });
                    }
                    skSetInitialGuess(sketch, initialGuessF3HD5PxY3AAr9PG_3);
                    skSolve(sketch);
                }
            };
        try(features.F3HD5PxY3AAr9PG_3(id));
        features.FiGsjAS4K608afc_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFiGsjAS4K608afc_0 = { "cbLMMlTDpqzD" : [0.03153187632262709, 0.11469736546278, -1.8369701987210317E-16, 1.0, -0.002250000000000002, -2.500000000000141E-4], "UO09WjTX66Vs" : [0.03346095989197493, 0.11444736546277999, 1.0, 2.449293598294708E-16, -0.0019290835693478378, 0.0020709164306521727], "MRnSsDL0k70R" : [0.0355318763226271, 0.10552606183290482, 1.2246467991473532E-16, -1.0, -0.008921303629875171, 0.07107869637012483], "SHbFc8mYeeN7" : [-0.10196812367737292, 0.10271107804775234, -3.0616169978683826E-16, -1.0, -0.011736287415027621, 0.018263712584972377], "pHUkbRTbEwS6" : [-0.034259040040317254, 0.05982588050385064, 0.9397934234884371, -0.3417430630867042, -0.07204677320014118, 0.07426197568385415], "SoIpyfPlK5qz" : [-0.09796812367737291, 0.09850999739766117, -3.0616169978683826E-16, -1.0, -0.01593736806511882, 0.011260922876437707], "FGxrECzZ95jq" : [-0.030674481734194126, 0.06277865926915846, 0.9397934234884372, -0.3417430630867042, -0.07160471680402938, 0.06619152305398804], "6gcJXOtRfsMk" : [0.03153187632262709, 0.0851607846915722, -2.4492935982947064E-16, 1.0, -0.045002619261257815, 0.027286580771207797], "MwS9J0AS5Ekm.0" : [-0.09702103668153284, 0.11569736546277995], "D3MJcjPeHZOe" : [-0.09810183582048122, 0.11444736546277996, 1.0, 0.0, -0.0038662878568916925, 1.337121431083249E-4] };
                    {
                    }
                    var ZsZbFQWIixjzRp_query;
                    ZsZbFQWIixjzRp_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S5.7$RightplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Case profile" }
                    var sketch = newSketch(context, id + "FiGsjAS4K608afc_0", { "sketchPlane" : qUnion([ZsZbFQWIixjzRp_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "cbLMMlTDpqzD", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "UO09WjTX66Vs", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "MRnSsDL0k70R", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "SHbFc8mYeeN7", { "construction" : false, "index" : "5" });
                    skLineSegment(sketch, "pHUkbRTbEwS6", { "construction" : false, "index" : "6" });
                    skLineSegment(sketch, "SoIpyfPlK5qz", { "construction" : false, "index" : "7" });
                    skLineSegment(sketch, "FGxrECzZ95jq", { "construction" : false, "index" : "8" });
                    skLineSegment(sketch, "6gcJXOtRfsMk", { "construction" : false, "index" : "9" });
                    skPoint(sketch, "MwS9J0AS5Ekm.0", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "D3MJcjPeHZOe", { "construction" : false, "index" : "10" });
                    {
                        var YdpyoLLFEJmnSe_query;
                        YdpyoLLFEJmnSe_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3.3$7b7PflQGYaBOtopend",id);
                        skConstraint(sketch, "cbLMMlTDpqzD.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "cbLMMlTDpqzD.start", "externalSecond" : qUnion([YdpyoLLFEJmnSe_query]) });
                    }
                    {
                        var cmVwBoeYIiWCtW_query;
                        cmVwBoeYIiWCtW_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6.3$7b7PflQGYaBObottomend",id);
                        skConstraint(sketch, "cbLMMlTDpqzD.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "cbLMMlTDpqzD.end", "externalSecond" : qUnion([cmVwBoeYIiWCtW_query]) });
                    }
                    {
                        skConstraint(sketch, "UO09WjTX66Vs.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "UO09WjTX66Vs.start", "localSecond" : "cbLMMlTDpqzD.end" });
                    }
                    {
                        var hAGJYiUswAzQLN_query;
                        hAGJYiUswAzQLN_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.5$7b7PflQGYaBOright",id);
                        skConstraint(sketch, "UO09WjTX66Vs.endSnap0", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "UO09WjTX66Vs", "externalSecond" : qUnion([hAGJYiUswAzQLN_query]) });
                    }
                    {
                        skConstraint(sketch, "X6J0K8yJDPHW", { "constraintType" : ConstraintType.LENGTH, "index" : "1", "name" : "", "localFirst" : "UO09WjTX66Vs", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('CaseFrontBackThickness')), 'expression' : "#CaseFrontBackThickness" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.5769400636119429, "labelDistance" : -0.0010822599530219967 * meter });
                    }
                    {
                        skConstraint(sketch, "MRnSsDL0k70R.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "MRnSsDL0k70R.start", "localSecond" : "UO09WjTX66Vs.end" });
                    }
                    {
                        skConstraint(sketch, "MRnSsDL0k70R.endSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "name" : "", "localFirst" : "MRnSsDL0k70R" });
                    }
                    {
                        skConstraint(sketch, "yR0n0ZloRNJ4", { "constraintType" : ConstraintType.LENGTH, "index" : "2", "name" : "", "localFirst" : "MRnSsDL0k70R", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('CaseRearHeight')), 'expression' : "#CaseRearHeight" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.6295261596220644, "labelDistance" : -0.0036883558601140953 * meter });
                    }
                    {
                        var LkVXcpeXBMNhRm_query;
                        LkVXcpeXBMNhRm_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSd.8$IAhQH5pdcXoa0MirrorCS",id);
                        skConstraint(sketch, "SHbFc8mYeeN7.endSnap0", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "SHbFc8mYeeN7", "externalSecond" : qUnion([LkVXcpeXBMNhRm_query]) });
                    }
                    {
                        skConstraint(sketch, "PWq36IIVWLTo", { "constraintType" : ConstraintType.LENGTH, "index" : "4", "name" : "", "localFirst" : "SHbFc8mYeeN7", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('Front_Height')), 'expression' : "#Front_Height" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.8395542557267609, "labelDistance" : 0.01304074156582355 * meter });
                    }
                    {
                        skConstraint(sketch, "pHUkbRTbEwS6.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "name" : "", "localFirst" : "pHUkbRTbEwS6.start", "localSecond" : "SHbFc8mYeeN7.end" });
                    }
                    {
                        skConstraint(sketch, "pHUkbRTbEwS6.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "name" : "", "localFirst" : "pHUkbRTbEwS6.end", "localSecond" : "MRnSsDL0k70R.end" });
                    }
                    {
                        var NPmaiGJlBvLkAc_query;
                        NPmaiGJlBvLkAc_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSd.8$9mwv8ZyL37Ap0MirrorCS",id);
                        skConstraint(sketch, "SoIpyfPlK5qz.endSnap0", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "SoIpyfPlK5qz", "externalSecond" : qUnion([NPmaiGJlBvLkAc_query]) });
                    }
                    {
                        skConstraint(sketch, "FGxrECzZ95jq.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "10", "name" : "", "localFirst" : "FGxrECzZ95jq.start", "localSecond" : "SoIpyfPlK5qz.end" });
                    }
                    {
                        skConstraint(sketch, "6gcJXOtRfsMk.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "11", "name" : "", "localFirst" : "6gcJXOtRfsMk.start", "localSecond" : "FGxrECzZ95jq.end" });
                    }
                    {
                        skConstraint(sketch, "6gcJXOtRfsMk.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "12", "name" : "", "localFirst" : "6gcJXOtRfsMk.end", "localSecond" : "cbLMMlTDpqzD.start" });
                    }
                    {
                        skConstraint(sketch, "Juc0MRxjL6X7", { "constraintType" : ConstraintType.PARALLEL, "index" : "3", "name" : "", "localFirst" : "6gcJXOtRfsMk", "localSecond" : "MRnSsDL0k70R" });
                    }
                    {
                        skConstraint(sketch, "4Dpcf6ohmNKW", { "constraintType" : ConstraintType.PARALLEL, "index" : "4", "name" : "", "localFirst" : "FGxrECzZ95jq", "localSecond" : "pHUkbRTbEwS6" });
                    }
                    {
                        skConstraint(sketch, "ADLOHVGYVQvM", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "localFirst" : "FGxrECzZ95jq", "localSecond" : "pHUkbRTbEwS6", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('CaseBottomThickness')), 'expression' : "#CaseBottomThickness" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.LEFT, "labelRatio" : 4.46166760014433, "labelDistance" : 0.06408812064288806 * meter });
                    }
                    {
                        var YYxHbRIJYqWaTW_query;
                        YYxHbRIJYqWaTW_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6.5$7b7PflQGYaBObottomstart",id);
                        skConstraint(sketch, "MwS9J0AS5Ekm.0.project", { "constraintType" : ConstraintType.PROJECTED, "index" : "1", "name" : "", "projectionType" : SketchProjectionType.USE, "localFirst" : "MwS9J0AS5Ekm.0", "externalSecond" : qUnion([YYxHbRIJYqWaTW_query]), "sketchToolType" : SketchToolType.USE });
                    }
                    {
                        skConstraint(sketch, "tXLH5gOwl2Sk.trimCoi", { "constraintType" : ConstraintType.COINCIDENT, "index" : "13", "name" : "", "localFirst" : "MwS9J0AS5Ekm.0", "localSecond" : "SoIpyfPlK5qz.start", "sketchToolType" : SketchToolType.EXTEND });
                    }
                    {
                        skConstraint(sketch, "7sr3uqeOPZpH0", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "SHbFc8mYeeN7.start", "localSecond" : "SoIpyfPlK5qz.start" });
                    }
                    {
                        skConstraint(sketch, "D3MJcjPeHZOe.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "14", "name" : "", "localFirst" : "D3MJcjPeHZOe.start", "localSecond" : "SHbFc8mYeeN7.start" });
                    }
                    {
                        skConstraint(sketch, "D3MJcjPeHZOe.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "15", "name" : "", "localFirst" : "D3MJcjPeHZOe.end", "localSecond" : "SoIpyfPlK5qz.start" });
                    }
                    {
                        skConstraint(sketch, "Y00QsZ7RKx8k", { "constraintType" : ConstraintType.LENGTH, "index" : "5", "name" : "", "localFirst" : "D3MJcjPeHZOe", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('CaseFrontBackThickness')), 'expression' : "#CaseFrontBackThickness" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : -3.5465639792850303, "labelDistance" : -0.010243045612928374 * meter });
                    }
                    skSetInitialGuess(sketch, initialGuessFiGsjAS4K608afc_0);
                    skSolve(sketch);
                }
            };
        try(features.FiGsjAS4K608afc_0(id));
        features.FMFhDfYjq2jKuAM_0 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var CyKwodmObvOZyZ_query;
                    CyKwodmObvOZyZ_query=qCompressed(1.0,"&388$eJyNkc1ymzAUhV9GXdqD+Gcpg4yZGmNf0Y7pJgNIU5SMDRUksd++AidNOnE82aF7dL9zjvi2cNDuUahz6jBsIi778lDJ34/lINtjVA4lwan5UcnPnWA+yrNtts7iQn+K4yAHKXriEjM0NK1CXCj5JPhStYdpUl4uncflRYnovwOzEY1iqlca2Q+tOr/gQ6AkT7KNFtpOqMk54QsTJZxghvHcRUtrFTnbU2ERooJtfGc9SyWyjgXoz9hqAnHEvtM8XN3RTZ7kBROofxBD3VwCJJzxuY8S0uxWTsfrfVsaqVSqVSEDB1zwwIcgrLXjjM89JA+dkscBauahJN1CssmjGZ5Ku2CPRd+2oIIaOOgI8xm2UY3rPtGBfwQ72wBjfFrAYIJFzMujgU30xL8JCQ7PT/6v89rySGeAE3rMRT8p5HT/ch2bOluAdC4KjIY5YOfrdHnyM7ZTD/FJgKYDrt9RAfMIv1u9zKxXA11f4z/vZYzqRySY9tfzWQt735wS5lZldi2fzvJ5QO0A5rUCbwlumq+b0LxPaVHdF7FxEwO4vKpP/8tGSxLS/7W/sAIIqQ==",id);
                    var lzAzcWImaqWvNh_query;
                    lzAzcWImaqWvNh_query=qCompressed(1.0,"&2a0$eJydkl1PwjAUhv9MvZSsk23scuzLCWN4WhW8IdtaoHzss6jj1zuGIRpNTLhp2vO+73POSXoz1NDjgVdNqBGsIibqeJ+I1SGWIs+cWMYWDtXfCm0KTgaIRtNoHPnz9sozKaTgtaVbqq20tAQxXok3zrwq33eV+GxqTuFhjNzLg/SR6/huG1mLWuZV84W3wbVoEE1aIS941XUO2FBFAbMwwbinI0/49cYi/ZGuDOJlulDeRcWjgpioPG3VgRgiI5fa9wt3QgM6JxzVWy7T9XmAgJEUpck4DHfUKcqjAxroYMAATDtt29yynoHEvqhEJiElBgrCKQQT6tzi86bQ785LChJIgQFvsU+RYr5s6EzXn+tvBqy2DnwHWPuXEEJGamesbA0FriOQPCia5XQ30srjdQTP/6hc+/hqapvyOoK+Sh9mkYRlHW7/JIBmG+0v8Czb/al9Al1xznU=",id);
                    var paULGsHxZTTzYw_query;
                    paULGsHxZTTzYw_query=qCompressed(1.0,"&3c6$eJydUl93mjAU/zLZox4DBMpjhKh0RewN7cZeepCkktMiFKIrfvpF7Ha6zbPu+Jbc+/t7kk9Tgm53su1jwrGFhOryaq02u1yrehvmOqc4tv7epH0j+RVKk1Vyk8wzc5RbrbSSHXWpFUxil6+RkK3aSzFr68pMCM9PoP5InuaI/bpwB7FwzgylVJ2u2/5NPgBG0yhZmkXdyHZwjsTUQpGgmGM8dtHMXoRk9ZrZlLb+av5gf1etTBruo5djq0FIIP6ZpcHigS3TKM24RN2T1EV5ChAJXhihLvb3N4svhORRsK61riuYHLsDBgtsag2tCDjUTCbDkYALHlyBD2soQIDkI2yPHfQsHzWQwOMuumeQsq8nVFCYzCMx9pCqmlZtNRQmZbRMGXAWpOEI/49FgYp9dfA37suBx64BYOcNgV0DwV6I37GOM+6hKF6BMQL8eHobcIzBZfUIatWm1GeMf6p/WMA6lHxl+fGUBJOzOv4fDcBy3on/I5yNdN2cI/sfkAv01Dvb8g5nRfzt9jKF0lfV9a65X7xey8sUuLDvMvpcbdSBn1UYfpWDZjRgv+9+AIHKHeY=",id);
                    annotation { "Feature Name" : "Case + blocks ex" }
                    extrude(context, id + "FMFhDfYjq2jKuAM_0", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([CyKwodmObvOZyZ_query, lzAzcWImaqWvNh_query, paULGsHxZTTzYw_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(lookup('HP_Count') * lookup('HP')), 'expression' : "#HP_Count*#HP" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FMFhDfYjq2jKuAM_0(id));
        features.Fqe20K2fBgPDH5f_3 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var CugXdDWYeNnOOb_query;
                    CugXdDWYeNnOOb_query=qCompressed(1.0,"&203$eJx9kU1zgjAQhv9MeqzDp8IxQMSM8mFCp6UXJkAqwSoYsMq/L8hML53xuLvP7vvu7otjgv2VyyEwqaqBUnTslIvDlfWiOXusZ1ANtP+VZGg5VXUQEezjEO4yD8Uo9FDoptQGjRQHcWbfHTRdZRzMAD/3oh+mLocB9BdQAyDPRzQHlej6Rs5JC7gEwQRH4VhoWi4fkrh0NIBLqFJVXSzBWt94ZnxPdQilHfuZfhOSR+2ofpnWeQwqAd2ixN1kKExwklIOuiPvi2o2gEtaLiyAYbXfmG1ZfDRMCYSUjXTpZJsYxCRLsiIWYSQnBZn413HpQi06PMq/2XtDeUqKuxXRvTz6d06ek7vK1eoApXmd+s9J+3T7sT6Hnb6CrUIMdzke0Ym8dIbdfD6QDdbBuvK+0vqi1dsrDDKladG9l9eSk3z8CH1HcZJNjb/JdqMN",id);
                    var qPjucVrUALGhuo_query;
                    qPjucVrUALGhuo_query=qCompressed(1.0,"&209$eJx1kctygzAMRX/G3XaAAglLwIZSAqS224RuGPNKTFLeTEO+vhBmuumwlHR0JV09GQp4H7J29BQiSiDlHfuO+WlgPa9KyHqmi570v0LHOiPiCwiwYzu+vosg2iMfIt8MiQaqlp94ya6drprCJMxAVva8H+cugwH0FxAZIGgjEoMz7/qqXZJbYGKkUyfwp0JVZ+1jpJMaEnBSXSSi+KwCi9tdoRPZVYUty5NI+OFtFtTT9GY+5yGUAuIiar5GyKcODUkGukvWJ+dlASclCUjineddKaybO5x3xTJWsIo3eIsZjnGCZ+gjELRDQY+q+tmtQh4uSQd3wmUj4FWIVE495vurqzT3Vciyby0y71+aUjSrkHpK3o5Bj/POu2DZVCcrjQCGC2fGi00asDzrDPOwaKTCHXQvEqoa3fp2SDMcT38hB7Sn0dz4C3kWp+8=",id);
                    var SkMswIUrLYHJBe_query;
                    SkMswIUrLYHJBe_query=qCompressed(1.0,"&1e7$eJx1UMtygjAU/Zl0WUdeVpYBoqDyMME6dMMESCUqDyG00q8vyEw3HZf3nsc997wYGth3rOldjUgyyHhLi4SfOip4VVpUUCi58n8k7GtGJAX42Fk7HtzFFgqQZyHPjIgOqoafeEmvLdTM+WBMASsFF/2oMihAfwNRAbLWiCQg562ommm5BCZGMHR8bwCqmjWPk05myMDJoEQkabYAK8W2tOAeKRA2erCOlW/eML8ert/Gdx5GGSBbFJp2jLzQCSPCQHthIs2nAE5G0sGodfWvnX3UNOqYSSVEVYyZsYo1vMBveIkpTnCKM/IqyTMFiKp+gqfg0qtlfpCi1P3YPyXlOi82Xf1u3zfsKYlkyiGC1+LEfwhWzcVQlOFb0cQzk6kEHazcVW59RuebfN520I3nVY3uoukyhpOhdXJEQRiPwl9nc50g",id);
                    annotation { "Feature Name" : "Case + blocks union" }
                    booleanBodies(context, id + "Fqe20K2fBgPDH5f_3", { "operationType" : BooleanOperationType.UNION, "tools" : qUnion([CugXdDWYeNnOOb_query, qPjucVrUALGhuo_query, SkMswIUrLYHJBe_query]), "targets" : qUnion([]), "offset" : false, "offsetAll" : false, "entitiesToOffset" : qUnion([]), "offsetDistance" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeDirection" : false, "reFillet" : false, "keepTools" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.Fqe20K2fBgPDH5f_3(id));
        features.Foyk2i1MdWTnpLh_2 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFoyk2i1MdWTnpLh_2 = { "16yyiVBsxS9C" : [0.03302103668153285, 0.11569736546277998, 1.0, -3.1069674196599535E-16, -0.06699999999999999, 0.06699999999999999], "MRbBneG7tRe9" : [0.10002103668153284, 0.09919736546277996, 0.0, -1.0, -0.016499999999999987, 0.0165], "npevhiGVPdE1" : [0.03302103668153285, 0.07169736546277998, -0.9867890916993085, -0.16201014938346833, -0.0678969807870718, 0.06789698078707182], "quFEu4ZacbDG" : [-0.03397896331846715, 0.08819736546278001, 2.5232341468753555E-16, 1.0, -0.02750000000000001, 0.027499999999999997] };
                    {
                    }
                    var QKxcIzklpdLxGc_query;
                    QKxcIzklpdLxGc_query=qCompressed(1.0,"&464$eJx9ktt2ojAYhV8mc9kuDoJyGSEc1Igm2BZvWBiiBA9gwFb79AN1TefQoZfJ/2VnZ+/8GBtgeeHyhg26ARmX4pVnriyPULcVbFJVA5mo0+NG7C5pI8qTkzYpVLH2dRLdKk5VHYQk8II5nCUOWqC5g+Z2TC1QSrETp/RQQ6MVNmgK+KkRza07NU4B+lzQAUCOh1o3uaibUt43R8AmCEZBOG8HZcXlx5VBNtZAkEGVquqjCVzdd4zFNdYhlNbCS/Q3IXlYtbefuyd+CGWATlFk+wmaR0EUUw7qPW9YfjcQZJS1QjW2Xmf+s2Gkgb0pm6Y8dp6JQUwyJCNikQ1hJCOcPqj6ow6asuqZM7C/DU75So0ZXi97odwSx8mlevKvE94L0UxfxfBw3Il3Sgx72AblQht1HB0CUdMmlU1ELJvd87CAi93c2cbFWSumF4gTpazQtZGXjBPWJQoXSafQFU3UrlSiEZ0M7g39x0P2OAIBzJe+UWXspUwVLKQspU17+QdNA0xlddA2s7KWA+VbUlxHIV3KvXfl5HtylttagVG8KWLve9I6vr2O1reZPoSV0lIq+8DUrE2KqNuW1ZQvAZh/S/5K9IEDV3h1AelgaiqjdMsS5bMetplhfIic6vzu/ONIVz+pVahYz0X0YppPdT+FyYnWzkzZDxXST7neVSL7fW0ZxbmfMnds8hI2ZFvjfT/l6HjCigX31yHvSen39p9f7Mw1Zaptx7uF4xvbRC+rcVkeeHpqv5gBMCIe+gnqhljy",id);
                    annotation { "Feature Name" : "C-cap profile" }
                    var sketch = newSketch(context, id + "Foyk2i1MdWTnpLh_2", { "sketchPlane" : qUnion([QKxcIzklpdLxGc_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "16yyiVBsxS9C", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "MRbBneG7tRe9", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "npevhiGVPdE1", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "quFEu4ZacbDG", { "construction" : false, "index" : "4" });
                    {
                        var YKsmEJcgPIEczO_query;
                        YKsmEJcgPIEczO_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$UO09WjTX66VsC0M5R4R5R6R7R8RaRbRcRdSc$MRnSsDL0k70RR4C6S6$VERTEXR6R7S7$isStartTR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "16yyiVBsxS9C.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "16yyiVBsxS9C.start", "externalSecond" : qUnion([YKsmEJcgPIEczO_query]) });
                    }
                    {
                        var XUaNffFQXnFuBn_query;
                        XUaNffFQXnFuBn_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$SHbFc8mYeeN7C0M5R4R5R6R7R8RaRbRcRdSc$D3MJcjPeHZOeR4C6S6$VERTEXR6R7S7$isStartTR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "16yyiVBsxS9C.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "16yyiVBsxS9C.end", "externalSecond" : qUnion([XUaNffFQXnFuBn_query]) });
                    }
                    {
                        skConstraint(sketch, "MRbBneG7tRe9.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "MRbBneG7tRe9.start", "localSecond" : "16yyiVBsxS9C.end" });
                    }
                    {
                        var KtmeTtLRdYqJQD_query;
                        KtmeTtLRdYqJQD_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$SHbFc8mYeeN7C0M5R4R5R6R7R8RaRbRcRdSc$pHUkbRTbEwS6R4C6S6$VERTEXR6R7S7$isStartTR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "MRbBneG7tRe9.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "MRbBneG7tRe9.end", "externalSecond" : qUnion([KtmeTtLRdYqJQD_query]) });
                    }
                    {
                        skConstraint(sketch, "npevhiGVPdE1.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "npevhiGVPdE1.start", "localSecond" : "MRbBneG7tRe9.end" });
                    }
                    {
                        var wLAVNDQEdhmjky_query;
                        wLAVNDQEdhmjky_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$MRnSsDL0k70RC0M5R4R5R6R7R8RaRbRcRdSc$pHUkbRTbEwS6R4C6S6$VERTEXR6R7S7$isStartTR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "npevhiGVPdE1.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "npevhiGVPdE1.end", "externalSecond" : qUnion([wLAVNDQEdhmjky_query]) });
                    }
                    {
                        skConstraint(sketch, "quFEu4ZacbDG.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "name" : "", "localFirst" : "quFEu4ZacbDG.start", "localSecond" : "npevhiGVPdE1.end" });
                    }
                    {
                        skConstraint(sketch, "quFEu4ZacbDG.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "name" : "", "localFirst" : "quFEu4ZacbDG.end", "localSecond" : "16yyiVBsxS9C.start" });
                    }
                    skSetInitialGuess(sketch, initialGuessFoyk2i1MdWTnpLh_2);
                    skSolve(sketch);
                }
            };
        try(features.Foyk2i1MdWTnpLh_2(id));
        features.FAkBXxkZm9SXX7u = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FAkBXxkZm9SXX7u", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "EndCapThickness", "lengthValue" : { 'value' : try(lookup('CaseFrontBackThickness')), 'expression' : "#CaseFrontBackThickness" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(lookup('CaseFrontBackThickness')), 'expression' : "#CaseFrontBackThickness" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FAkBXxkZm9SXX7u(id));
        features.Fj4R7BItooHmHyP_2 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var mCVVhxggwVvmOG_query;
                    mCVVhxggwVvmOG_query=qCompressed(1.0,"&940$eJytVNtyqjAU/ZmcRx0SCMojQlSOIjShF/viIATFqiDQVvz6E1BbPdW25zLjOLqzL2vttZIfHQxunnlW2phBBMI491fTePbsF3GyNv3C16GNPp54ZcpZG3iO6wyd3lj85OsiLmKe66qODMlW2RSEPItfeNjNkpWIYObvk8qquOMD8vaHKYCYPSJK5nFeJFl5aG9QonuWMxIHScqzerIVdhCwQh0yCJsq6CblE4qhHd5763Q4n6DXOONOyjSwqVjVjULABsQz+hMy8ixvzDjIn3gRzPcArJAFAKplGd918i3TDCpVnCmkiMo6qtlgquxZUaX+PmQwKAOHWj1rpA8nJnHJyCQjYyyGJ1k8i9f+Mj+UY6rSFm1TzQj2yBscdONevtCZMlClth8FE4kGNKRcoAmmQ9teema62Znn5RQqb1nqLPj54BQ0yu2nYwZrgThnhZ8V3vssDXTt7tyMxosNWgyedXsiJSnZFtlzyGlQ7Vl3J5UA58zryZKO6ggUH6TD62Tkvond7VjW9UxzexP5CFNolNvay7B/j7FvGdOkKJKVaKnUzcRCKVKubVwc/UYfoUPfBoJNBSx5VFBstJgK7gj1yMMJrgaMmmIbqzSL14WgqQFr5BHKiOGZDfitIUKJl9VOm6mbHRNQMUX+MSUQKSg04WmZiIn9W7ZLxSThjgh49JacGKOGqoCubpCjnJUAPmD3xPUmVfywdHh96acWuHUk7X7hPajqXS4yFOmkLVXgR6WEFTYcSQMUdWau2cfRRE7STpIsub8WSDBg7tAS2KUTsvtths0GaoGaNUXRZ7fia9gssdIycpcDvNm9ZcDAOyKH0Z868V2zsNkGAQxySxjyVrtRJDvOsiQz2JnncHDVczi43roht4C2en1pP5ZDuaWn0gVPnG3ny27xtu2wm+ypt+X0YjcZ/2YxKvsCtRxe0PvPzGPK9s9g4fL+o8M/NQ9VwirCz21BMbqAsA4KhO9L2FuDytEVpT/Wyvi8trqj6v95MjAQD/O8uLzob74JaDdnLtLsDjau6H9dsb9agOArXbwQnwl9RlsGRZL+s2G6vW1GjN2jhheb7xnmM1/Qlv+1b8RN9f+e+v6KDecGWthkPF2Me9Il3D7+JvTT4kP0F/lNpLA=",id);
                    var OXZczSlGksYhyn_query;
                    OXZczSlGksYhyn_query=qCompressed(1.0,"&8e1$eJylVNuSojoU/ZnMoxYJF+URISKjCJ3QF/vF4hIUWwUBe9SvPwG1G6fV6TlTRVm4sy9rrb3Cj54MHrYs39syhQhESeGvgmS29cskXRt+6WvQRl9PvH3GaBd4juuMHHPCX9m6TMqEFZqiIV2wFRqAiOXJO4v6ebriEZn6x6R9VdzzAf74QyWADRPzknlSlGm+P7XXCdY8yxnzgzRjeT3ZinoIWJEGKYRtBfTT/RtKoB09e+tsNJ+iX0nOnIyqYFOxqhtFgA6xpw+meOxZ3oQyULyxMpwfAVgRDQFU9vvkqVfsqKoToeJMIEFE1FDNRibSkRWR6t9TBoUicIhlWmNtNDWwi8cGHusTPjzNk1my9pfFqVwmCumQLlH18Ii8xUA/MYuFRqWhInT9OJwKJCQRYRxNGIxse+kZ2eZgXJYTKH1kKbPw54tTkriw384ZtAOSgpZ+Xnqfs1TQt/tzI54sNmgx3Gr2VEgzvCvzbcRIWOmsudNqAZfM68mChuoI5A/S4G0y4sCQ3d1E1LRcdc2peIbJd1TY6vto8CzLvqUHaVmmK95SqptxQQmSbinOj36jj9CpbwvBtgSWLC6JrHeoAp4w8fBLA1cLxm2uxirLk3XJaarAGnuYUKx7Rgt+awjfxPvqoM6UzYFyqDJB/jkl5CkoMmCzjMe4/pbtEj6JuyMGHnnEDWPUUCXQ13R8Xme1AB/QZ+x60yp+Eh3eFr1pgUdHUJ8X3ouiPBU8QxIabYkEv26KW2HDkDBEcW/mGgM5nopp1kvTJfPXHIkMqDuyOHahQfaoZtRuoQ6oWRMUN+SDwm/4gg94m20fb6VXPwwMs6mejI59xGZZHRR9HjxftQrGLWfcmWqToLdmZqckTL02tYn+653+s+g0tbJ97C6H8ubwkQFD76w7jP/2Hn06Lmp3QQjDwuLX6VF9kAQ7yfM01+nFjVGCm7oowe3WLVEF6urXe/d1PxI7WiZccfTlbv/ULdl1HfqQv5k7Rq52u9hwHeQbhkSMrrj176xviPbPcOGywavD7lqfSFEVYZem/pYH5Upr4cr5p0jnb5hwdef3uFx8ykRQptk/a9I3dznWD6+qvNh8T5O71Lvq3fOzGdX/T/3ootFcRwsbT4LFxBSu4Vbjb0JvFp+i/wFD9YrR",id);
                    annotation { "Feature Name" : "C-cap ex" }
                    extrude(context, id + "Fj4R7BItooHmHyP_2", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([mCVVhxggwVvmOG_query, OXZczSlGksYhyn_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(lookup('EndCapThickness')), 'expression' : "#EndCapThickness" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.Fj4R7BItooHmHyP_2(id));
        features.F2BB50DkTKoPje6_3 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var PUpEouaPYYyZBc_query;
                    PUpEouaPYYyZBc_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    var QKsfkKnyyOEnLL_query;
                    QKsfkKnyyOEnLL_query=qCompressed(1.0,"&203$eJx9kU1zgjAQhv9MeqzDp8IxQMSM8mFCp6UXJkAqwSoYsMq/L8hML53xuLvP7vvu7otjgv2VyyEwqaqBUnTslIvDlfWiOXusZ1ANtP+VZGg5VXUQEezjEO4yD8Uo9FDoptQGjRQHcWbfHTRdZRzMAD/3oh+mLocB9BdQAyDPRzQHlej6Rs5JC7gEwQRH4VhoWi4fkrh0NIBLqFJVXSzBWt94ZnxPdQilHfuZfhOSR+2ofpnWeQwqAd2ixN1kKExwklIOuiPvi2o2gEtaLiyAYbXfmG1ZfDRMCYSUjXTpZJsYxCRLsiIWYSQnBZn413HpQi06PMq/2XtDeUqKuxXRvTz6d06ek7vK1eoApXmd+s9J+3T7sT6Hnb6CrUIMdzke0Ym8dIbdfD6QDdbBuvK+0vqi1dsrDDKladG9l9eSk3z8CH1HcZJNjb/JdqMN",id);
                    annotation { "Feature Name" : "Case + cap union" }
                    booleanBodies(context, id + "F2BB50DkTKoPje6_3", { "operationType" : BooleanOperationType.UNION, "tools" : qUnion([PUpEouaPYYyZBc_query, QKsfkKnyyOEnLL_query]), "targets" : qUnion([]), "offset" : false, "offsetAll" : false, "entitiesToOffset" : qUnion([]), "offsetDistance" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeDirection" : false, "reFillet" : false, "keepTools" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F2BB50DkTKoPje6_3(id));
        features.F3xT4oM5hgqciRt = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "F3xT4oM5hgqciRt", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "EndCapTabThickness", "lengthValue" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F3xT4oM5hgqciRt(id));
        features.FNqrsvGVGM0ZkbD_3 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFNqrsvGVGM0ZkbD_3 = { "CCN8qFGedmqF" : [-0.09306888746172187, 0.10244736546277998, 1.0, 6.123233995736766E-17, -0.003899236215651025, 0.003899236215651025], "wVqSvTjFnr09" : [-0.0969681236773729, 0.09489983488622637, 1.2246467991473532E-16, -1.0, -0.007547530576553607, 0.010599282937574048], "341IgwYjpyLz" : [-0.032718123677372896, 0.06217784132594173, 0.9455201091752599, -0.32556370059514406, -0.06795201855203561, 0.06795201855203561], "VN8xnNqsZKE1" : [0.03153187632262711, 0.0579556024562553, 0.0, 1.0, -0.017900471753024172, 0.04449176300652468], "eW2TvYbvpQhK" : [0.028557284886379444, 0.10244736546278, -1.0, -1.1102230246251565E-16, -0.002974591436247634, 0.0020254085637523463], "dkjp0VnBosyx" : [0.026531876322627098, 0.09020992290973662, 1.2246467991473532E-16, -1.0, -0.012237442553043376, 0.043145085655941565], "eW0jhRAeEetY" : [-0.03190580583603551, 0.06718623697142977, -0.94552010917526, 0.32556370059514395, -0.06180480096783505, 0.06352304647833179], "3ZamyaBeXbFH" : [-0.09196812367737289, 0.09746358685235314, -2.4492935982947064E-16, 1.0, -0.009596551796360347, 0.004983778610426842], "SzScduo859dH.orphan" : [-0.08916965124607085, 0.08690345846792542] };
                    {
                    }
                    var nrGzHrhbryCWEM_query;
                    nrGzHrhbryCWEM_query=qCompressed(1.0,"&464$eJx9ktt2ojAYhV8mc9kuDoJyGSEc1Igm2BZvWBiiBA9gwFb79AN1TefQoZfJ/2VnZ+/8GBtgeeHyhg26ARmX4pVnriyPULcVbFJVA5mo0+NG7C5pI8qTkzYpVLH2dRLdKk5VHYQk8II5nCUOWqC5g+Z2TC1QSrETp/RQQ6MVNmgK+KkRza07NU4B+lzQAUCOh1o3uaibUt43R8AmCEZBOG8HZcXlx5VBNtZAkEGVquqjCVzdd4zFNdYhlNbCS/Q3IXlYtbefuyd+CGWATlFk+wmaR0EUUw7qPW9YfjcQZJS1QjW2Xmf+s2Gkgb0pm6Y8dp6JQUwyJCNikQ1hJCOcPqj6ow6asuqZM7C/DU75So0ZXi97odwSx8mlevKvE94L0UxfxfBw3Il3Sgx72AblQht1HB0CUdMmlY1LLJvd87CAi93c2cbFWSumF4gTpazQtZGXjBPWJQoXSafQFU3UrlSiEZ0M7g39x0P2OAIBzJe+UWXspUwVLKQspU17+QdNA0xlddA2s7KWA+VbUlxHIV3KvXfl5HtylttagVG8KWLve9I6vr2O1reZPoSV0lIq+8DUrE2KqNuW1ZQvAZh/S/5K9IEDV3h1AelgaiqjdMsS5bMetplhfIic6vzu/ONIVz+pVahYz0X0YppPdT+FyYnWzkzZDxXST7neVSL7fW0ZxbmfMnds8hI2ZFvjfT/l6HjCigX31yHvSen39p9f7Mw1Zaptx7uF4xvbRC+rcVkeeHpqv5gBMCIe+gmu6ljI",id);
                    annotation { "Feature Name" : "End cap tab profile" }
                    var sketch = newSketch(context, id + "FNqrsvGVGM0ZkbD_3", { "sketchPlane" : qUnion([nrGzHrhbryCWEM_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "CCN8qFGedmqF", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "wVqSvTjFnr09", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "341IgwYjpyLz", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "VN8xnNqsZKE1", { "construction" : false, "index" : "4" });
                    skLineSegment(sketch, "eW2TvYbvpQhK", { "construction" : false, "index" : "5" });
                    skLineSegment(sketch, "dkjp0VnBosyx", { "construction" : false, "index" : "6" });
                    skLineSegment(sketch, "eW0jhRAeEetY", { "construction" : false, "index" : "7" });
                    skLineSegment(sketch, "3ZamyaBeXbFH", { "construction" : false, "index" : "8" });
                    skPoint(sketch, "SzScduo859dH.orphan", { "construction" : false, "index" : "1" });
                    {
                        var MwqFxTzyyRltMV_query;
                        MwqFxTzyyRltMV_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSd.8$LhC2jMEYbjYG0MirrorCSC0M5R4R5R6R7R8RaRbRcRdSd.-13$9mwv8ZyL37Ap0R4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "CCN8qFGedmqF.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "CCN8qFGedmqF.start", "externalSecond" : qUnion([MwqFxTzyyRltMV_query]) });
                    }
                    {
                        var KDavHDIwomTHUs_query;
                        KDavHDIwomTHUs_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSd.8$IAhQH5pdcXoa0MirrorCSC0M5R4R5R6R7R8RaRbRcRdSd.-13$LhC2jMEYbjYG0R4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "CCN8qFGedmqF.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "CCN8qFGedmqF.end", "externalSecond" : qUnion([KDavHDIwomTHUs_query]) });
                    }
                    {
                        skConstraint(sketch, "wVqSvTjFnr09.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "wVqSvTjFnr09.start", "localSecond" : "CCN8qFGedmqF.start" });
                    }
                    {
                        var nSElgjbpXgAthp_query;
                        nSElgjbpXgAthp_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$SoIpyfPlK5qzC0M5R4R5R6R7R8RaRbRcRdSc$FGxrECzZ95jqR4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "wVqSvTjFnr09.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "wVqSvTjFnr09.end", "externalSecond" : qUnion([nSElgjbpXgAthp_query]) });
                    }
                    {
                        skConstraint(sketch, "341IgwYjpyLz.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "341IgwYjpyLz.start", "localSecond" : "wVqSvTjFnr09.end" });
                    }
                    {
                        var ClaQzrfYzxZBGs_query;
                        ClaQzrfYzxZBGs_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$FGxrECzZ95jqC0M5R4R5R6R7R8RaRbRcRdSc$6gcJXOtRfsMkR4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "341IgwYjpyLz.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "341IgwYjpyLz.end", "externalSecond" : qUnion([ClaQzrfYzxZBGs_query]) });
                    }
                    {
                        skConstraint(sketch, "VN8xnNqsZKE1.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "name" : "", "localFirst" : "VN8xnNqsZKE1.start", "localSecond" : "341IgwYjpyLz.end" });
                    }
                    {
                        var hOhcQqLBOhDJZl_query;
                        hOhcQqLBOhDJZl_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$sM9vLHW55aICtopC0M5R4R5R6R7R8RaRbRcRdS-12.4$leftR4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "VN8xnNqsZKE1.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "name" : "", "localFirst" : "VN8xnNqsZKE1.end", "externalSecond" : qUnion([hOhcQqLBOhDJZl_query]) });
                    }
                    {
                        skConstraint(sketch, "eW2TvYbvpQhK.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "9", "name" : "", "localFirst" : "eW2TvYbvpQhK.start", "localSecond" : "VN8xnNqsZKE1.end" });
                    }
                    {
                        skConstraint(sketch, "dkjp0VnBosyx.endSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "name" : "", "localFirst" : "dkjp0VnBosyx" });
                    }
                    {
                        skConstraint(sketch, "eW0jhRAeEetY.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "12", "name" : "", "localFirst" : "eW0jhRAeEetY.start", "localSecond" : "dkjp0VnBosyx.end" });
                    }
                    {
                        var VfpLAUdGDOlHtM_query;
                        VfpLAUdGDOlHtM_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSd.8$IAhQH5pdcXoa0MirrorCSC0M5R4R5R6R7R8RaRbRcRdSd.-13$LhC2jMEYbjYG0R4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "eW0jhRAeEetY.endSnap0", { "constraintType" : ConstraintType.VERTICAL, "index" : "2", "name" : "", "localFirst" : "SzScduo859dH.orphan", "externalSecond" : qUnion([VfpLAUdGDOlHtM_query]) });
                    }
                    {
                        skConstraint(sketch, "hSZZqa17EfZA", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "eW0jhRAeEetY", "localSecond" : "341IgwYjpyLz" });
                    }
                    {
                        skConstraint(sketch, "Gj62XXPZ5DQj", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "localFirst" : "eW0jhRAeEetY", "localSecond" : "341IgwYjpyLz", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('EndCapTabThickness')), 'expression' : "#EndCapTabThickness" }.value, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.LEFT, "labelRatio" : 3.096941363429369, "labelDistance" : -0.05124372310263757 * meter });
                    }
                    {
                        skConstraint(sketch, "u6aUsrR8rcok", { "constraintType" : ConstraintType.DISTANCE, "index" : "2", "name" : "", "localFirst" : "3ZamyaBeXbFH", "localSecond" : "wVqSvTjFnr09", "direction" : DimensionDirection.MINIMUM, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.LEFT, "labelRatio" : 2.914461327171901, "labelDistance" : 0.03881611840170511 * meter, "length" : { 'value' : try(lookup('EndCapTabThickness')), 'expression' : "#EndCapTabThickness" }.value });
                    }
                    {
                        skConstraint(sketch, "SzScduo859dH.orphanCoi1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "13", "name" : "", "localFirst" : "eW0jhRAeEetY", "localSecond" : "SzScduo859dH.orphan", "sketchToolType" : SketchToolType.EXTEND });
                    }
                    {
                        skConstraint(sketch, "9WGvYwEgVciu.trimCoi", { "constraintType" : ConstraintType.COINCIDENT, "index" : "14", "name" : "", "localFirst" : "eW0jhRAeEetY.end", "localSecond" : "3ZamyaBeXbFH.start", "sketchToolType" : SketchToolType.TRIM });
                    }
                    {
                        skConstraint(sketch, "WfknZbiWPf50", { "constraintType" : ConstraintType.DISTANCE, "index" : "3", "name" : "", "localFirst" : "dkjp0VnBosyx", "localSecond" : "VN8xnNqsZKE1", "direction" : DimensionDirection.MINIMUM, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.LEFT, "labelRatio" : 3.3927972178778467, "labelDistance" : 0.01955893182270779 * meter, "length" : { 'value' : try(lookup('EndCapTabThickness')), 'expression' : "#EndCapTabThickness" }.value });
                    }
                    {
                        skConstraint(sketch, "wHInVE0qJGLe.trimCoi", { "constraintType" : ConstraintType.COINCIDENT, "index" : "16", "name" : "", "localFirst" : "dkjp0VnBosyx.start", "localSecond" : "eW2TvYbvpQhK.end", "sketchToolType" : SketchToolType.TRIM });
                    }
                    {
                        skConstraint(sketch, "sXvgxJeylBbt", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "eW2TvYbvpQhK.end", "localSecond" : "VN8xnNqsZKE1.end" });
                    }
                    skSetInitialGuess(sketch, initialGuessFNqrsvGVGM0ZkbD_3);
                    skSolve(sketch);
                }
            };
        try(features.FNqrsvGVGM0ZkbD_3(id));
        features.F2TJ85Dnplgcjye_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "F2TJ85Dnplgcjye_4", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "EndCapTabDepth", "lengthValue" : { 'value' : try(lookup('BottomHoleInset') + (.7 * lookup('BoltCounterboreDiam'))), 'expression' : "#BottomHoleInset+(.7*#BoltCounterboreDiam)" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(lookup('BottomHoleInset') + (.7 * lookup('BoltCounterboreDiam'))), 'expression' : "#BottomHoleInset+(.7*#BoltCounterboreDiam)" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F2TJ85Dnplgcjye_4(id));
        features.FnrYYWGKd7PIsmq = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FnrYYWGKd7PIsmq", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "BoltThrougDiam", "lengthValue" : { 'value' : try(3.3 * millimeter), 'expression' : "3.3 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(3.3 * millimeter), 'expression' : "3.3 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FnrYYWGKd7PIsmq(id));
        features.FyPyYQCk6KhN0b4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FyPyYQCk6KhN0b4", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "BottomHoleSpacing", "lengthValue" : { 'value' : try(55 * millimeter), 'expression' : "55 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(55 * millimeter), 'expression' : "55 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FyPyYQCk6KhN0b4(id));
        features.Fugsa1H96ki7JJ7_3 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var ZKzRNhcOaiSNZJ_query;
                    ZKzRNhcOaiSNZJ_query = qSketchRegion(id + "FNqrsvGVGM0ZkbD_3", true);
                    var AhCLZDhJCpLGxQ_query;
                    AhCLZDhJCpLGxQ_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    annotation { "Feature Name" : "Endcap tab ex" }
                    extrude(context, id + "Fugsa1H96ki7JJ7_3", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([ZKzRNhcOaiSNZJ_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(lookup('EndCapTabDepth')), 'expression' : "#EndCapTabDepth" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([AhCLZDhJCpLGxQ_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.Fugsa1H96ki7JJ7_3(id));
        features.FG84VuVG8ehPTnr_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var JYVdMcDpjOpqQW_query;
                    JYVdMcDpjOpqQW_query = qSketchRegion(id + "Foyk2i1MdWTnpLh_2", true);
                    var RhrzCkLYTLedPG_query;
                    RhrzCkLYTLedPG_query=qCompressed(1.0,"&464$eJx9ktt2ojAYhV8mc9kuDoJyGSEc1Igm2BZvWBiiBA9gwFb79AN1TefQoZfJ/2VnZ+/8GBtgeeHyhg26ARmX4pVnriyPULcVbFJVA5mo0+NG7C5pI8qTkzYpVLH2dRLdKk5VHYQk8II5nCUOWqC5g+Z2TC1QSrETp/RQQ6MVNmgK+KkRza07NU4B+lzQAUCOh1o3uaibUt43R8AmCEZBOG8HZcXlx5VBNtZAkEGVquqjCVzdd4zFNdYhlNbCS/Q3IXlYtbefuyd+CGWATlFk+wmaR0EUUw7qPW9YfjcQZJS1QjW2Xmf+s2Gkgb0pm6Y8dp6JQUwyJCNikQ1hJCOcPqj6ow6asuqZM7C/DU75So0ZXi97odwSx8mlevKvE94L0UxfxfBw3Il3Sgx72AblQht1HB0CUdMmlY1LLJvd87CAi93c2cbFWSumF4gTpazQtZGXjBPWJQoXSafQFU3UrlSiEZ0M7g39x0P2OAIBzJe+UWXspUwVLKQspU17+QdNA0xlddA2s7KWA+VbUlxHIV3KvXfl5HtylttagVG8KWLve9I6vr2O1reZPoSV0lIq+8DUrE2KqNuW1ZQvAZh/S/5K9IEDV3h1AelgaiqjdMsS5bMetplhfIic6vzu/ONIVz+pVahYz0X0YppPdT+FyYnWzkzZDxXST7neVSL7fW0ZxbmfMnds8hI2ZFvjfT/l6HjCigX31yHvSen39p9f7Mw1Zaptx7uF4xvbRC+rcVkeeHpqv5gBMCIe+gmu6ljI",id);
                    var YnjMlIiPrJUMBl_query;
                    YnjMlIiPrJUMBl_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    annotation { "Feature Name" : "Endcap ex" }
                    extrude(context, id + "FG84VuVG8ehPTnr_4", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([JYVdMcDpjOpqQW_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(lookup('EndCapThickness')), 'expression' : "#EndCapThickness" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : true, "startOffsetBound" : StartOffsetType.ENTITY, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([RhrzCkLYTLedPG_query]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([YnjMlIiPrJUMBl_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FG84VuVG8ehPTnr_4(id));
        features.FVGkha6q3kr9MoT_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var aJmlkVvmEIkftj_query;
                    aJmlkVvmEIkftj_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$eW0jhRAeEetYR4C6S4$FACER6R7R8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbSa$SWEPT_FACE",id);
                    var DMsjvEIfFSVJpM_query;
                    DMsjvEIfFSVJpM_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$341IgwYjpyLzR4C6S4$FACER6R7R8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbSa$SWEPT_FACE",id);
                    annotation { "Feature Name" : "interior bottom plane" }
                    cPlane(context, id + "FVGkha6q3kr9MoT_4", { "entities" : qUnion([aJmlkVvmEIkftj_query, DMsjvEIfFSVJpM_query]), "cplaneType" : CPlaneType.MID_PLANE, "offset" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "angle" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "oppositeDirection" : false, "flipAlignment" : false, "flipNormal" : false, "width" : { 'value' : try(150 * millimeter), 'expression' : "150 mm" }.value, "height" : { 'value' : try(150 * millimeter), 'expression' : "150 mm" }.value, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FVGkha6q3kr9MoT_4(id));
        features.FkHd7zO9gFunJkQ_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFkHd7zO9gFunJkQ_4 = { "hRbrUcCn7aXx.0" : [0.13208, 0.030760203921937554, 0.0, -1.0, -0.0682664815264417, 0.06826648152644174], "A4q9gXyYQF6Q.0" : [0.12908, 0.03985992924455499, 0.0, -1.0, -0.059166756203824264, 0.07736620684905916], "t99kJ28t9PV8" : [0.13208, 0.03076020392193754], "qvz2E4E18BUs" : [0.12908, 0.03076020392193754], "A4q9gXyYQF6Q.0.offset" : [0.0, 0.0, 0.0, 0.0] };
                    {
                    }
                    var phDqRefnemEQTI_query;
                    phDqRefnemEQTI_query=qCompressed(1.0,"&21b$eJxtkM1yozAQhF9Ge9wUkg22jwIEphwwO2KT8omSkRKEY0QAJ8vbR9hVW5Wfo3rUPV/PL99Ffy6qn1KXH5FUvX5TMurNmZLAsRomSOpBnI/6+SJGbdpQjILilHyfFFOnOF6gPSRxktH7MmQ5y0KWBQe+QabXz7oVLwPF12CBVDvqcZpdvkDs/4MvEQtjZmlqPYymv4lrFACjRbLP7MB0qr+uTKRPUCIp5hjfeSjS8dBQvtx5zlo8VaXzrnu17+z217niNUgivmNFsC1ZViTFgSs0nNRY1TeARPIKddu/pyMUR/bOPXCDlSWKaMBgBWvYBNVt2wZFaVSHT4fmlTS7C01Lx3Ts39hfpILK1uOPLC/K2Tj3BTwfDQgsYHm7ALjgfY78rVBkphPROJWPRdvd1yWBCiQoC9V26q3W8UMuGbZWvPzixbZ+Y0U/GY3ZnrdTfjXj1Q+fLTvxfdcJT8XO5I3yyoXpfGNelGgtu4tSBjH7ALUWqsI=",id);
                    annotation { "Feature Name" : "bottom hole setup 1" }
                    var sketch = newSketch(context, id + "FkHd7zO9gFunJkQ_4", { "sketchPlane" : qUnion([phDqRefnemEQTI_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "hRbrUcCn7aXx.0", { "construction" : true, "index" : "1" });
                    skLineSegment(sketch, "A4q9gXyYQF6Q.0", { "construction" : true, "index" : "2" });
                    skPoint(sketch, "t99kJ28t9PV8", { "construction" : false, "index" : "1" });
                    skPoint(sketch, "qvz2E4E18BUs", { "construction" : false, "index" : "2" });
                    {
                        var PYvKAgigZIeysZ_query;
                        PYvKAgigZIeysZ_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$SHbFc8mYeeN7C0M5R4R5R6R7R8RaRbRcRdSc$pHUkbRTbEwS6R4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        var eXaydRuQNogavH_query;
                        eXaydRuQNogavH_query=qCompressed(1.0,"&464$eJx9ktt2ojAYhV8mc9kuDoJyGSEc1Igm2BZvWBiiBA9gwFb79AN1TefQoZfJ/2VnZ+/8GBtgeeHyhg26ARmX4pVnriyPULcVbFJVA5mo0+NG7C5pI8qTkzYpVLH2dRLdKk5VHYQk8II5nCUOWqC5g+Z2TC1QSrETp/RQQ6MVNmgK+KkRza07NU4B+lzQAUCOh1o3uaibUt43R8AmCEZBOG8HZcXlx5VBNtZAkEGVquqjCVzdd4zFNdYhlNbCS/Q3IXlYtbefuyd+CGWATlFk+wmaR0EUUw7qPW9YfjcQZJS1QjW2Xmf+s2Gkgb0pm6Y8dp6JQUwyJCNikQ1hJCOcPqj6ow6asuqZM7C/DU75So0ZXi97odwSx8mlevKvE94L0UxfxfBw3Il3Sgx72AblQht1HB0CUdMmlY1LLJvd87CAi93c2cbFWSumF4gTpazQtZGXjBPWJQoXSafQFU3UrlSiEZ0M7g39x0P2OAIBzJe+UWXspUwVLKQspU17+QdNA0xlddA2s7KWA+VbUlxHIV3KvXfl5HtylttagVG8KWLve9I6vr2O1reZPoSV0lIq+8DUrE2KqNuW1ZQvAZh/S/5K9IEDV3h1AelgaiqjdMsS5bMetplhfIic6vzu/ONIVz+pVahYz0X0YppPdT+FyYnWzkzZDxXST7neVSL7fW0ZxbmfMnds8hI2ZFvjfT/l6HjCigX31yHvSen39p9f7Mw1Zaptx7uF4xvbRC+rcVkeeHpqv5gBMCIe+gmu6ljI",id);
                        var cnrxHXKPYUtikF_query;
                        cnrxHXKPYUtikF_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$pHUkbRTbEwS6R4R5R6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "hRbrUcCn7aXx.0.start.project", { "constraintType" : ConstraintType.PROJECTED, "index" : "1", "name" : "", "projectionType" : SketchProjectionType.USE_END, "localFirst" : "hRbrUcCn7aXx.0.start", "externalVertex" : qUnion([PYvKAgigZIeysZ_query]), "externalVertexEdge" : qUnion([qCoEdge(eXaydRuQNogavH_query, cnrxHXKPYUtikF_query)]), "sketchToolType" : SketchToolType.USE });
                    }
                    {
                        var fZBmqODlWwyEAY_query;
                        fZBmqODlWwyEAY_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$MRnSsDL0k70RC0M5R4R5R6R7R8RaRbRcRdSc$pHUkbRTbEwS6R4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        var BkUnxEgYdoHiuv_query;
                        BkUnxEgYdoHiuv_query=qCompressed(1.0,"&464$eJx9ktt2ojAYhV8mc9kuDoJyGSEc1Igm2BZvWBiiBA9gwFb79AN1TefQoZfJ/2VnZ+/8GBtgeeHyhg26ARmX4pVnriyPULcVbFJVA5mo0+NG7C5pI8qTkzYpVLH2dRLdKk5VHYQk8II5nCUOWqC5g+Z2TC1QSrETp/RQQ6MVNmgK+KkRza07NU4B+lzQAUCOh1o3uaibUt43R8AmCEZBOG8HZcXlx5VBNtZAkEGVquqjCVzdd4zFNdYhlNbCS/Q3IXlYtbefuyd+CGWATlFk+wmaR0EUUw7qPW9YfjcQZJS1QjW2Xmf+s2Gkgb0pm6Y8dp6JQUwyJCNikQ1hJCOcPqj6ow6asuqZM7C/DU75So0ZXi97odwSx8mlevKvE94L0UxfxfBw3Il3Sgx72AblQht1HB0CUdMmlY1LLJvd87CAi93c2cbFWSumF4gTpazQtZGXjBPWJQoXSafQFU3UrlSiEZ0M7g39x0P2OAIBzJe+UWXspUwVLKQspU17+QdNA0xlddA2s7KWA+VbUlxHIV3KvXfl5HtylttagVG8KWLve9I6vr2O1reZPoSV0lIq+8DUrE2KqNuW1ZQvAZh/S/5K9IEDV3h1AelgaiqjdMsS5bMetplhfIic6vzu/ONIVz+pVahYz0X0YppPdT+FyYnWzkzZDxXST7neVSL7fW0ZxbmfMnds8hI2ZFvjfT/l6HjCigX31yHvSen39p9f7Mw1Zaptx7uF4xvbRC+rcVkeeHpqv5gBMCIe+gmu6ljI",id);
                        var ubmkQfkOYdAyzV_query;
                        ubmkQfkOYdAyzV_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$pHUkbRTbEwS6R4R5R6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "hRbrUcCn7aXx.0.end.project", { "constraintType" : ConstraintType.PROJECTED, "index" : "2", "name" : "", "projectionType" : SketchProjectionType.USE_END, "localFirst" : "hRbrUcCn7aXx.0.end", "externalVertex" : qUnion([fZBmqODlWwyEAY_query]), "externalVertexEdge" : qUnion([qCoEdge(BkUnxEgYdoHiuv_query, ubmkQfkOYdAyzV_query)]), "sketchToolType" : SketchToolType.USE });
                    }
                    {
                        var hEsStxdIfZAYQZ_query;
                        hEsStxdIfZAYQZ_query=qCompressed(1.0,"&464$eJx9ktt2ojAYhV8mc9kuDoJyGSEc1Igm2BZvWBiiBA9gwFb79AN1TefQoZfJ/2VnZ+/8GBtgeeHyhg26ARmX4pVnriyPULcVbFJVA5mo0+NG7C5pI8qTkzYpVLH2dRLdKk5VHYQk8II5nCUOWqC5g+Z2TC1QSrETp/RQQ6MVNmgK+KkRza07NU4B+lzQAUCOh1o3uaibUt43R8AmCEZBOG8HZcXlx5VBNtZAkEGVquqjCVzdd4zFNdYhlNbCS/Q3IXlYtbefuyd+CGWATlFk+wmaR0EUUw7qPW9YfjcQZJS1QjW2Xmf+s2Gkgb0pm6Y8dp6JQUwyJCNikQ1hJCOcPqj6ow6asuqZM7C/DU75So0ZXi97odwSx8mlevKvE94L0UxfxfBw3Il3Sgx72AblQht1HB0CUdMmlY1LLJvd87CAi93c2cbFWSumF4gTpazQtZGXjBPWJQoXSafQFU3UrlSiEZ0M7g39x0P2OAIBzJe+UWXspUwVLKQspU17+QdNA0xlddA2s7KWA+VbUlxHIV3KvXfl5HtylttagVG8KWLve9I6vr2O1reZPoSV0lIq+8DUrE2KqNuW1ZQvAZh/S/5K9IEDV3h1AelgaiqjdMsS5bMetplhfIic6vzu/ONIVz+pVahYz0X0YppPdT+FyYnWzkzZDxXST7neVSL7fW0ZxbmfMnds8hI2ZFvjfT/l6HjCigX31yHvSen39p9f7Mw1Zaptx7uF4xvbRC+rcVkeeHpqv5gBMCIe+gmu6ljI",id);
                        var XUfECTYSHfbjor_query;
                        XUfECTYSHfbjor_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$pHUkbRTbEwS6R4R5R6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "hRbrUcCn7aXx.0.project", { "constraintType" : ConstraintType.PROJECTED, "index" : "3", "name" : "", "projectionType" : SketchProjectionType.USE, "localFirst" : "hRbrUcCn7aXx.0", "externalSecond" : qUnion([qCoEdge(hEsStxdIfZAYQZ_query, XUfECTYSHfbjor_query)]), "sketchToolType" : SketchToolType.USE });
                    }
                    {
                        skConstraint(sketch, "A4q9gXyYQF6Q.distance", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "localFirst" : "hRbrUcCn7aXx.0", "localSecond" : "A4q9gXyYQF6Q.0", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('BottomHoleInset')), 'expression' : "#BottomHoleInset" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.LEFT, "labelRatio" : 0.5000000000000004, "labelDistance" : -6.938893903907228E-18 * meter, "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        skConstraint(sketch, "A4q9gXyYQF6Q.0.offset", { "constraintType" : ConstraintType.OFFSET, "index" : "1", "name" : "", "localOffset" : "A4q9gXyYQF6Q.0", "localMaster" : "hRbrUcCn7aXx.0", "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        skConstraint(sketch, "Ogblv6zdPblS", { "constraintType" : ConstraintType.EQUAL, "index" : "1", "name" : "", "localFirst" : "A4q9gXyYQF6Q.0", "localSecond" : "hRbrUcCn7aXx.0" });
                    }
                    {
                        var eLaLmMfGWIOOhf_query;
                        eLaLmMfGWIOOhf_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$pHUkbRTbEwS6R4R5R6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "t99kJ28t9PV8.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localEntity1" : "t99kJ28t9PV8", "externalEntity2" : qUnion([eLaLmMfGWIOOhf_query]) });
                    }
                    {
                        skConstraint(sketch, "qvz2E4E18BUs.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "2", "name" : "", "localEntity1" : "qvz2E4E18BUs", "localEntity2" : "A4q9gXyYQF6Q.0" });
                    }
                    {
                        skConstraint(sketch, "kBQnTQUh5won", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "qvz2E4E18BUs", "localSecond" : "t99kJ28t9PV8" });
                    }
                    skSetInitialGuess(sketch, initialGuessFkHd7zO9gFunJkQ_4);
                    skSolve(sketch);
                }
            };
        try(features.FkHd7zO9gFunJkQ_4(id));
        features.Flw25JlSkmsU0oX_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var rvzbQbiPZtusfP_query;
                    rvzbQbiPZtusfP_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FkHd7zO9gFunJkQ_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.1.5$A4q9gXyYQF6Q0start",id);
                    var xbBVeJApHExffZ_query;
                    xbBVeJApHExffZ_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FkHd7zO9gFunJkQ_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.1.3$A4q9gXyYQF6Q0end",id);
                    var huVdJsHTFsYAyo_query;
                    huVdJsHTFsYAyo_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FkHd7zO9gFunJkQ_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.1$A4q9gXyYQF6Q0",id);
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "Flw25JlSkmsU0oX_4", { "initEntities" : qUnion([]), "mode" : VariableMode.MEASURED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.LENGTH, "name" : "BaseCase", "lengthValue" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "angleValue" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "numberValue" : { 'value' : try(0), 'expression' : "0" }.value, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try("?"), 'expression' : "\"?\"" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "0" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([rvzbQbiPZtusfP_query, xbBVeJApHExffZ_query]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "xOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "yOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "zOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "lengthEntities" : qUnion([huVdJsHTFsYAyo_query]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.Flw25JlSkmsU0oX_4(id));
        features.Fye0YOE2wKHU4mw = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "Fye0YOE2wKHU4mw", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "BaseCaseInset", "lengthValue" : { 'value' : try(lookup('BaseCase') - (3 * lookup('CaseFrontBackThickness'))), 'expression' : "#BaseCase-(3*#CaseFrontBackThickness)" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(lookup('BaseCase') - (3 * lookup('CaseFrontBackThickness'))), 'expression' : "#BaseCase-(3*#CaseFrontBackThickness)" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.Fye0YOE2wKHU4mw(id));
        features.FcjJB77x9zw5ukM_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFcjJB77x9zw5ukM_4 = { "Nu0ceNbW6JXf" : [0.12608, 0.030760203921937537], "Qb2h421UmeXP" : [0.12608, 0.030760203921937537], "QzmdjCwwSGju" : [0.12608, 0.030760203921937537, 1.0, 0.0, 0.00275, -1.0], "0eicr7sgVYf7" : [0.12608, 0.030760203921937537, 1.0, 0.0, 0.0021000000000000003, -1.0] };
                    {
                    }
                    var hJSLHcuBzKunpD_query;
                    hJSLHcuBzKunpD_query=qCompressed(1.0,"&451$eJylk1lzmzAUhf+M+pgOkjGYRxaBqc2SK9qM+8KwyLFMDIQlqfvrK9tZSN1pH/rCIF3d75x7BJ+sObodeXcM5gwTVIo+O+TifswG0dRONmQmDsh1JTm2nC1QEsXROvI28pXXgxgE703VJLYiaTkqeSeeeOl2zUHuaKCcWIAZnqEIfM8PzXXq0JiGDg3tDTNQ04l7UWcPvYnPiOxCPZ7UrAzRtwVTEXU8KjV2oh+a7vjixwZqJn4UykLT8u5s1S8tgvzSlLr4s4Zc4fV7k6krTVlk2yJVnkXHo1aqP55iOINKxFY0sZcpDRM/2TCO+ooPxe5iwC9Zgdrl1yqHJKfPTAMdFmBAxnQkejZk3eBCbvOLooHcwN05283+kexXoxmkStPSH0M3lhzOns04PQ3zSnlv1ZFbLUv9Z2Tcu2P9pbpNVXFoO1EPslFHfhCDHybODb4kDuo0ZZiDdonxGnyDFeQ2x4oIHJR3Sd2udykBDlvAipytbvnTTnjf4pLit2asuVPAArl7FXTLH5pmeVge4zMAG+9igIvTTulM7cnny2pqk3y0CeW7lwBq1jtrpdIVAEym+IVMIUPsjsbJOcBrLBD1NzKZjPk4unRUv2dF7njTI4Y8MptdpyZvkljWXHGqZNXEe66ls6a1muaBZ7W0MkcBhek1vgYApPifBNgyd4vFYcN5qF8nIJ3+EzYdOoDcqrmny0/IkPH8bW6YnVzM+B8mwlvQbUP+ha5p04+1X96tT1M=",id);
                    annotation { "Feature Name" : "bottom hole setup 2" }
                    var sketch = newSketch(context, id + "FcjJB77x9zw5ukM_4", { "sketchPlane" : qUnion([hJSLHcuBzKunpD_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skPoint(sketch, "Nu0ceNbW6JXf", { "construction" : false, "index" : "1" });
                    skPoint(sketch, "Qb2h421UmeXP", { "construction" : false, "index" : "2" });
                    skCircle(sketch, "QzmdjCwwSGju", { "construction" : false, "index" : "1" });
                    skCircle(sketch, "0eicr7sgVYf7", { "construction" : false, "index" : "2" });
                    {
                        var ysUwlscWodrMqo_query;
                        ysUwlscWodrMqo_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FkHd7zO9gFunJkQ_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.1$A4q9gXyYQF6Q0",id);
                        skConstraint(sketch, "Nu0ceNbW6JXf.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localEntity1" : "Nu0ceNbW6JXf", "externalEntity2" : qUnion([ysUwlscWodrMqo_query]) });
                    }
                    {
                        skConstraint(sketch, "MGhnXZli4brQ", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "Qb2h421UmeXP", "localSecond" : "Nu0ceNbW6JXf" });
                    }
                    {
                        skConstraint(sketch, "QzmdjCwwSGju.centerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "QzmdjCwwSGju.center", "localSecond" : "Nu0ceNbW6JXf" });
                    }
                    {
                        skConstraint(sketch, "jQXUMXj2qaHk", { "constraintType" : ConstraintType.DIAMETER, "index" : "1", "name" : "", "localFirst" : "QzmdjCwwSGju", "length" : { 'value' : try(lookup('BoltCounterboreDiam')), 'expression' : "#BoltCounterboreDiam" }.value, "labelRatio" : 8.52833232197847, "labelAngle" : -0.10399905816033124 * radian });
                    }
                    {
                        skConstraint(sketch, "0eicr7sgVYf7.centerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "0eicr7sgVYf7.center", "localSecond" : "Nu0ceNbW6JXf" });
                    }
                    {
                        skConstraint(sketch, "j1B6rX56mA8v", { "constraintType" : ConstraintType.DIAMETER, "index" : "2", "name" : "", "localFirst" : "0eicr7sgVYf7", "length" : { 'value' : try(lookup('BoltThrougDiam')), 'expression' : "#BoltThrougDiam" }.value, "labelRatio" : 3.325272128274036, "labelAngle" : -1.5707963267948966 * radian });
                    }
                    skSetInitialGuess(sketch, initialGuessFcjJB77x9zw5ukM_4);
                    skSolve(sketch);
                }
            };
        try(features.FcjJB77x9zw5ukM_4(id));
        features.FfcABLuY30nKeNb_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var OKkvzYMrRGXAfQ_query;
                    OKkvzYMrRGXAfQ_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FcjJB77x9zw5ukM_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$QzmdjCwwSGjuR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    var fmmBuqCkzMYqpM_query;
                    fmmBuqCkzMYqpM_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FcjJB77x9zw5ukM_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$0eicr7sgVYf7R5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    var OAMaQQXJyEJvxr_query;
                    OAMaQQXJyEJvxr_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    annotation { "Feature Name" : "bottom counterbore" }
                    extrude(context, id + "FfcABLuY30nKeNb_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([OKkvzYMrRGXAfQ_query, fmmBuqCkzMYqpM_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(lookup('BoltCounterboreThick')), 'expression' : "#BoltCounterboreThick" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([OAMaQQXJyEJvxr_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FfcABLuY30nKeNb_7(id));
        features.FsLQ5EL9BLcQbVr_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var BiGXyLkWuXFWNR_query;
                    BiGXyLkWuXFWNR_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FcjJB77x9zw5ukM_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$QzmdjCwwSGjuR4C6S4$BODYR6R7R8CbA1S11.9$FfcABLuY30nKeNb_7opExtrudeRbSa$SWEPT_BODY",id);
                    var NCjPnlYPmoGKwE_query;
                    NCjPnlYPmoGKwE_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FkHd7zO9gFunJkQ_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.1$hRbrUcCn7aXx0",id);
                    var gpvFerzmbfYKRg_query;
                    gpvFerzmbfYKRg_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    annotation { "Feature Name" : "bottom cb pattern" }
                    linearPattern(context, id + "FsLQ5EL9BLcQbVr_8", { "patternType" : PatternType.PART, "operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([BiGXyLkWuXFWNR_query]), "faces" : qUnion([]), "instanceFunction" : try(featureList({})), "directionOne" : qUnion([NCjPnlYPmoGKwE_query]), "distance" : { 'value' : try(lookup('BottomHoleSpacing')), 'expression' : "#BottomHoleSpacing" }.value, "instanceCount" : { 'value' : try(roundWithinTolerance(2)), 'expression' : "2" }.value, "oppositeDirection" : false, "isCentered" : true, "hasSecondDir" : false, "directionTwo" : qUnion([]), "distanceTwo" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "instanceCountTwo" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "1" }.value, "oppositeDirectionTwo" : false, "isCenteredTwo" : false, "defaultScope" : false, "booleanScope" : qUnion([gpvFerzmbfYKRg_query]), "fullFeaturePattern" : false, "skipInstances" : false, "skippedInstances" : [], "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FsLQ5EL9BLcQbVr_8(id));
        features.FSIawrh931dMhUy_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var UKfzDzUKaunJDG_query;
                    UKfzDzUKaunJDG_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FcjJB77x9zw5ukM_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$0eicr7sgVYf7R5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    annotation { "Feature Name" : "bottom through" }
                    extrude(context, id + "FSIawrh931dMhUy_4", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([UKfzDzUKaunJDG_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(10 * millimeter), 'expression' : "10 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FSIawrh931dMhUy_4(id));
        features.FNyk1TmTfAs3XhN_5 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var DeFxaoslzHOJzU_query;
                    DeFxaoslzHOJzU_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FcjJB77x9zw5ukM_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$0eicr7sgVYf7R4C6S4$BODYR6R7R8CbA1S11.9$FSIawrh931dMhUy_4opExtrudeRbSa$SWEPT_BODY",id);
                    var xHJQnrIguSMmql_query;
                    xHJQnrIguSMmql_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$npevhiGVPdE1R4R5R6R7S7$isStartFR8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbS8$CAP_EDGE",id);
                    var hIsoaKtzcKcTVD_query;
                    hIsoaKtzcKcTVD_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    var DPerExrYXKQGmR_query;
                    DPerExrYXKQGmR_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    annotation { "Feature Name" : "bottom through pattern" }
                    linearPattern(context, id + "FNyk1TmTfAs3XhN_5", { "patternType" : PatternType.PART, "operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([DeFxaoslzHOJzU_query]), "faces" : qUnion([]), "instanceFunction" : try(featureList({})), "directionOne" : qUnion([xHJQnrIguSMmql_query]), "distance" : { 'value' : try(lookup('BottomHoleSpacing')), 'expression' : "#BottomHoleSpacing" }.value, "instanceCount" : { 'value' : try(roundWithinTolerance(3)), 'expression' : "3" }.value, "oppositeDirection" : false, "isCentered" : true, "hasSecondDir" : false, "directionTwo" : qUnion([]), "distanceTwo" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "instanceCountTwo" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "1" }.value, "oppositeDirectionTwo" : false, "isCenteredTwo" : false, "defaultScope" : false, "booleanScope" : qUnion([hIsoaKtzcKcTVD_query, DPerExrYXKQGmR_query]), "fullFeaturePattern" : false, "skipInstances" : false, "skippedInstances" : [], "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FNyk1TmTfAs3XhN_5(id));
        features.FEgylpGpriUs7TI_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFEgylpGpriUs7TI_4 = { "17x9eEqAN0ou.0" : [0.13208, 0.11569736546277995], "aNPUadkDB9nF.0" : [0.13208, 0.08269736546277995], "6c0TnD9svONB" : [0.1524, 0.09794736546277996, 0.0, 1.0, -0.0165, 0.0165], "iwYSKckpetWH.0" : [0.1484, 0.09794736546277996, 0.0, 1.0, -0.0165, 0.01950000000000003], "AzYFvjmGqtxB" : [0.1484, 0.09944736546277998], "tdjqtSejeSsz" : [0.1484, 0.09944736546277998, 1.0, 0.0, 0.003, -1.0], "rlji1LmZW4Ae" : [0.1484, 0.09944736546277998, 1.0, 0.0, 0.00165, -1.0], "iwYSKckpetWH.0.offset" : [0.0, 0.0, 0.0, 0.0], "TcroqwvwxbYx" : [1.5707963267948966] };
                    {
                    }
                    var ePtCRxHiIyzeEI_query;
                    ePtCRxHiIyzeEI_query=qCompressed(1.0,"&21b$eJxtkFtvozAQhf+M93FX2AkheeRiCEoh2TFSlSfk4Glj0mAKTrv8+zWJVGkvjz7jc+Y78y3yyc8bDlPhixNROOgPVOlgriGLPadRRpQe5fWkX2/SatMl0sqQFuzfSTX1KOiC7CHP8jJ8qhN+4GXCy/goNsQM+lV38m0M6T1YEuysttPsiiThXw+xJDzJuKM569Ga4SGuSQw8rPJ96Qamx+G+MlcRI7kKqaD0x4qkOhvbUCx3K28tX5ra+9QD7nu3/X2ueA9SROx4FW9rXlZ5dRRIxgva5vwAyJVoiNie0mZ9PSKWAfhx4IjSMOYQwBo2cfPYtiFpkZ6Tl2P7ztrdLSxqz/T8lx1uCqFx9cQzP1T1bJz7Ap2PBgwWsHxcAHxY/Rn5HUlqpgvTtFDPVdc/nWsGDShAB1XAKeowCyzgxlnp8i8vdfVbJ0a5NWZ73U6Hu5kG//ns2FkU+V5yqXbm0OKqXpg+MuYNZefYfVJwyPhvV8yqNQ==",id);
                    annotation { "Feature Name" : "front hole setup" }
                    var sketch = newSketch(context, id + "FEgylpGpriUs7TI_4", { "sketchPlane" : qUnion([ePtCRxHiIyzeEI_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skPoint(sketch, "17x9eEqAN0ou.0", { "construction" : false, "index" : "1" });
                    skPoint(sketch, "aNPUadkDB9nF.0", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "6c0TnD9svONB", { "construction" : true, "index" : "1" });
                    skLineSegment(sketch, "iwYSKckpetWH.0", { "construction" : true, "index" : "2" });
                    skPoint(sketch, "AzYFvjmGqtxB", { "construction" : false, "index" : "3" });
                    skCircle(sketch, "tdjqtSejeSsz", { "construction" : false, "index" : "1" });
                    skCircle(sketch, "rlji1LmZW4Ae", { "construction" : false, "index" : "2" });
                    {
                        var efwMxxhdAELOEb_query;
                        efwMxxhdAELOEb_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$SHbFc8mYeeN7C0M5R4R5R6R7R8RaRbRcRdSc$D3MJcjPeHZOeR4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "17x9eEqAN0ou.0.project", { "constraintType" : ConstraintType.PROJECTED, "index" : "1", "name" : "", "projectionType" : SketchProjectionType.USE, "localFirst" : "17x9eEqAN0ou.0", "externalSecond" : qUnion([efwMxxhdAELOEb_query]), "sketchToolType" : SketchToolType.USE });
                    }
                    {
                        var vomRgacouatyeJ_query;
                        vomRgacouatyeJ_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$SHbFc8mYeeN7C0M5R4R5R6R7R8RaRbRcRdSc$pHUkbRTbEwS6R4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "aNPUadkDB9nF.0.project", { "constraintType" : ConstraintType.PROJECTED, "index" : "2", "name" : "", "projectionType" : SketchProjectionType.USE, "localFirst" : "aNPUadkDB9nF.0", "externalSecond" : qUnion([vomRgacouatyeJ_query]), "sketchToolType" : SketchToolType.USE });
                    }
                    {
                        skConstraint(sketch, "6c0TnD9svONB.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "6c0TnD9svONB.start", "localSecond" : "aNPUadkDB9nF.0" });
                    }
                    {
                        skConstraint(sketch, "6c0TnD9svONB.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "6c0TnD9svONB.end", "localSecond" : "17x9eEqAN0ou.0" });
                    }
                    {
                        skConstraint(sketch, "iwYSKckpetWH.distance", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "localFirst" : "6c0TnD9svONB", "localSecond" : "iwYSKckpetWH.0", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('BottomHoleInset')), 'expression' : "#BottomHoleInset" }.value, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : 1.9965807398160285, "labelDistance" : -0.023699946701526642 * meter, "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        skConstraint(sketch, "iwYSKckpetWH.0.offset", { "constraintType" : ConstraintType.OFFSET, "index" : "1", "name" : "", "localOffset" : "iwYSKckpetWH.0", "localMaster" : "6c0TnD9svONB", "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        skConstraint(sketch, "AzYFvjmGqtxB.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localEntity1" : "AzYFvjmGqtxB", "localEntity2" : "iwYSKckpetWH.0" });
                    }
                    {
                        skConstraint(sketch, "tdjqtSejeSsz.centerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "tdjqtSejeSsz.center", "localSecond" : "AzYFvjmGqtxB" });
                    }
                    {
                        skConstraint(sketch, "rlji1LmZW4Ae.centerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "rlji1LmZW4Ae.center", "localSecond" : "AzYFvjmGqtxB" });
                    }
                    {
                        skConstraint(sketch, "t6pg2g65sGnM", { "constraintType" : ConstraintType.DIAMETER, "index" : "1", "name" : "", "localFirst" : "tdjqtSejeSsz", "length" : { 'value' : try(lookup('BoltCounterboreDiam')), 'expression' : "#BoltCounterboreDiam" }.value, "labelRatio" : 3.5641181923766623, "labelAngle" : 2.1845884019567823 * radian });
                    }
                    {
                        skConstraint(sketch, "bvc4c9rWfaCF", { "constraintType" : ConstraintType.DIAMETER, "index" : "2", "name" : "", "localFirst" : "rlji1LmZW4Ae", "length" : { 'value' : try(lookup('BoltThrougDiam')), 'expression' : "#BoltThrougDiam" }.value, "labelRatio" : 3.3418096170012968, "labelAngle" : 2.8610868675253283 * radian });
                    }
                    {
                        var qPBAsnLONBxltu_query;
                        qPBAsnLONBxltu_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$sM9vLHW55aICtopR4C6S4$FACER6R7R8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$SWEPT_FACE",id);
                        var SiZWfeNkMuLBOt_query;
                        SiZWfeNkMuLBOt_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$sM9vLHW55aICtopC0M5R4R5R6R7R8RaRbRcRdS-12.5$rightR4R5R6R7R8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$SWEPT_EDGE",id);
                        skConstraint(sketch, "TcroqwvwxbYx", { "constraintType" : ConstraintType.TANGENT, "index" : "1", "name" : "", "externalFirst" : qUnion([qCoEdge(qPBAsnLONBxltu_query, SiZWfeNkMuLBOt_query)]), "localSecond" : "tdjqtSejeSsz" });
                    }
                    skSetInitialGuess(sketch, initialGuessFEgylpGpriUs7TI_4);
                    skSolve(sketch);
                }
            };
        try(features.FEgylpGpriUs7TI_4(id));
        features.FooSyLHAn0dpOmm_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var AxdSfxbvyttyLO_query;
                    AxdSfxbvyttyLO_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FEgylpGpriUs7TI_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$rlji1LmZW4AeR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    var OdBbRGgYwItUyn_query;
                    OdBbRGgYwItUyn_query=qCompressed(1.0,"&197$eJxlT11PwjAU/TPXR4idG4PHshVsBIZtjcEXMtYbKDI2uqKZv94yDNH4ctN7z1fP3TiC5zPadh5JEoA2TV5uzPacO1Md09zllMyD/4hqa5RDUNkym2XTlX/i0RlnsKEBDZJ777YBjdZ8oJ7Yquwu+ZXUXsTjHNhtkSGwdMq8ZGcaV9n2xz4RjCqeLTxQ1Wi7ZK7HAXBNiSSkP4AJ27aHelpb89LEiq/DT2Mxq+UITpdWnZEG+cRU8rhmC8XVSiI07+iK3fUDXMsCnN6fnMQ9yuZLRGIgYjEUo6TwMT3dj8GUPuHoRCFj4POl4AuVkmtREXbzJhIbUQgt0Lvaw96QWfn2GlL8RSCBZ5CHtEdElMS+/IQm7C/2DWw4hGA=",id);
                    var sLjwQnpGKaxpNF_query;
                    sLjwQnpGKaxpNF_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    annotation { "Feature Name" : "front counterbore" }
                    extrude(context, id + "FooSyLHAn0dpOmm_4", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([AxdSfxbvyttyLO_query, OdBbRGgYwItUyn_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(lookup('BoltCounterboreThick')), 'expression' : "#BoltCounterboreThick" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([sLjwQnpGKaxpNF_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FooSyLHAn0dpOmm_4(id));
        features.FJGshAX9WBxZLQN_5 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var kcLuptNIrYJfYy_query;
                    kcLuptNIrYJfYy_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FEgylpGpriUs7TI_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$tdjqtSejeSszR4C6S4$BODYR6R7R8CbA1S11.9$FooSyLHAn0dpOmm_4opExtrudeRbSa$SWEPT_BODY",id);
                    var UeUTsSUJDawAnF_query;
                    UeUTsSUJDawAnF_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$SHbFc8mYeeN7R4R5R6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbS8$CAP_EDGE",id);
                    var YbhPVaxESUwIaM_query;
                    YbhPVaxESUwIaM_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    annotation { "Feature Name" : "front cb pattern" }
                    linearPattern(context, id + "FJGshAX9WBxZLQN_5", { "patternType" : PatternType.PART, "operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([kcLuptNIrYJfYy_query]), "faces" : qUnion([]), "instanceFunction" : try(featureList({})), "directionOne" : qUnion([UeUTsSUJDawAnF_query]), "distance" : { 'value' : try(lookup('RearHoleSpacing')), 'expression' : "#RearHoleSpacing" }.value, "instanceCount" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "1" }.value, "oppositeDirection" : false, "isCentered" : true, "hasSecondDir" : false, "directionTwo" : qUnion([]), "distanceTwo" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "instanceCountTwo" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "1" }.value, "oppositeDirectionTwo" : false, "isCenteredTwo" : false, "defaultScope" : false, "booleanScope" : qUnion([YbhPVaxESUwIaM_query]), "fullFeaturePattern" : false, "skipInstances" : false, "skippedInstances" : [], "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FJGshAX9WBxZLQN_5(id));
        features.F5hLjtWl45gnYnz_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var ETaWrpizbsLOLV_query;
                    ETaWrpizbsLOLV_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FEgylpGpriUs7TI_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$rlji1LmZW4AeR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    annotation { "Feature Name" : "front through" }
                    extrude(context, id + "F5hLjtWl45gnYnz_4", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([ETaWrpizbsLOLV_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F5hLjtWl45gnYnz_4(id));
        features.FAggATVdCwCYYZu_5 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var KAFwhVbTgTQIsv_query;
                    KAFwhVbTgTQIsv_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FEgylpGpriUs7TI_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$rlji1LmZW4AeR4C6S4$BODYR6R7R8CbA1S11.9$F5hLjtWl45gnYnz_4opExtrudeRbSa$SWEPT_BODY",id);
                    var PClsfBVafCTDPZ_query;
                    PClsfBVafCTDPZ_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FEgylpGpriUs7TI_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$6c0TnD9svONB",id);
                    annotation { "Feature Name" : "front through pattern" }
                    linearPattern(context, id + "FAggATVdCwCYYZu_5", { "patternType" : PatternType.PART, "operationType" : NewBodyOperationType.NEW, "entities" : qUnion([KAFwhVbTgTQIsv_query]), "faces" : qUnion([]), "instanceFunction" : try(featureList({})), "directionOne" : qUnion([PClsfBVafCTDPZ_query]), "distance" : { 'value' : try(lookup('RearHoleSpacing')), 'expression' : "#RearHoleSpacing" }.value, "instanceCount" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "1" }.value, "oppositeDirection" : false, "isCentered" : true, "hasSecondDir" : false, "directionTwo" : qUnion([]), "distanceTwo" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "instanceCountTwo" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "1" }.value, "oppositeDirectionTwo" : false, "isCenteredTwo" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "fullFeaturePattern" : false, "skipInstances" : false, "skippedInstances" : [], "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FAggATVdCwCYYZu_5(id));
        features.FOXGwrJD83Ktmdd_5 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var ygiSXcbcMzvsmU_query;
                    ygiSXcbcMzvsmU_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FEgylpGpriUs7TI_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$rlji1LmZW4AeR4C6S4$BODYR6R7R8CbA1S11.9$F5hLjtWl45gnYnz_4opExtrudeRbSa$SWEPT_BODY",id);
                    var dmLlOJmLhOetVl_query;
                    dmLlOJmLhOetVl_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    var jqcWhKxDWeRtyy_query;
                    jqcWhKxDWeRtyy_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    annotation { "Feature Name" : "front through cut" }
                    booleanBodies(context, id + "FOXGwrJD83Ktmdd_5", { "operationType" : BooleanOperationType.SUBTRACTION, "tools" : qUnion([ygiSXcbcMzvsmU_query]), "targets" : qUnion([dmLlOJmLhOetVl_query, jqcWhKxDWeRtyy_query]), "offset" : false, "offsetAll" : false, "entitiesToOffset" : qUnion([]), "offsetDistance" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeDirection" : false, "reFillet" : false, "keepTools" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FOXGwrJD83Ktmdd_5(id));
        features.FPs6SSSPjT9zNdc_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFPs6SSSPjT9zNdc_4 = { "oLvPNL3KUD9k" : [-0.1524, 0.07444736546277997, 0.0, -1.0, -0.04000000000000002, 0.04000000000000001], "sBn2qlbh9JXS.0" : [-0.1484, 0.07616087296335348, 0.0, -1.0, -0.04846069143108343, 0.0018877064322303932], "pJt9DqmTCMvs" : [-0.1484, 0.09944736546278, 1.0, 0.0, 0.00165, -1.0], "bSogARb8m3IL" : [-0.1484, 0.09944736546278, 1.0, 0.0, 0.003, -1.0], "XamdLEhmN7Ax" : [-0.1484, 0.09381790088846856, 0.0, -1.0, -0.03080366350596836, -0.014629464574311454], "WnMT0ThIYVpH" : [-0.1484, 0.0927229053094429, 0.0, -1.0, -0.015724460153337116, -0.009724460153337111], "oUj9SKXSWzoF.0" : [-0.1484, 0.11444736546277998], "nWHqTrWTFTgT.0" : [-0.1564, 0.11444736546277999], "ulWKLNSoIQU5" : [-0.1564, 0.1079027368426323, 0.0, -1.0, -0.006544628620147694, 0.008455371379852292], "sBn2qlbh9JXS.0.offset" : [0.0, 0.0, 0.0, 0.0], "7J9X8KfqlZkv" : [1.5707963267948966] };
                    {
                    }
                    var xVWfVHeZmsaogF_query;
                    xVWfVHeZmsaogF_query=qCompressed(1.0,"&21b$eJxtkEuPozAQhP+M57gj7EAeRwOGoASSaSONshfkYE9ikmDCY3f492sSaaTZ3aOrXdVf9YvvobdBtWPq8SOSqtW/lIxac6MkcKyGCZK6E7ejPg2i16YORS8oTsm/k3xsFMcztIMkTjK6LUK2Z1nIsuDAV8i0+qRrce0ofgQLpOpe9+Pk8gViXw/uIhbGzNKcddeb9ikuUQCM5skuswPTqPaxMpE+QYmkmGP8OkeRjruKcnczd5bioyyc37pVu8Zuv08VH0ES8Q3Lg3XBsjzJD1yh7qL68vwESCQvUQo178Ktc1k4AF6wsEQRDRgsYAmroHxuW6Eojc7hx6G6k2oz0LRwTMM++3aQCkpbj7+zfV5Mxqkv4OloQGAG7vMC4MH8e+QPhSIzXojGqXzP62Z7LgiUIEFZqPsQscH9KcpjGFsrdv/yYlu/sqKf9Masb+tx/zDjxX8+W3bi+54TXvKN2VdqXsxM4xtzVaK27B5KGcTsDzC4qiY=",id);
                    annotation { "Feature Name" : "rear hole setup" }
                    var sketch = newSketch(context, id + "FPs6SSSPjT9zNdc_4", { "sketchPlane" : qUnion([xVWfVHeZmsaogF_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "oLvPNL3KUD9k", { "construction" : true, "index" : "1" });
                    skLineSegment(sketch, "sBn2qlbh9JXS.0", { "construction" : true, "index" : "2" });
                    skCircle(sketch, "pJt9DqmTCMvs", { "construction" : false, "index" : "1" });
                    skCircle(sketch, "bSogARb8m3IL", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "XamdLEhmN7Ax", { "construction" : true, "index" : "3" });
                    skLineSegment(sketch, "WnMT0ThIYVpH", { "construction" : true, "index" : "4" });
                    skPoint(sketch, "oUj9SKXSWzoF.0", { "construction" : false, "index" : "1" });
                    skPoint(sketch, "nWHqTrWTFTgT.0", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "ulWKLNSoIQU5", { "construction" : true, "index" : "5" });
                    {
                        var SYVrRslsuWmMiz_query;
                        SYVrRslsuWmMiz_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$UO09WjTX66VsC0M5R4R5R6R7R8RaRbRcRdSc$MRnSsDL0k70RR4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "oLvPNL3KUD9k.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "oLvPNL3KUD9k.start", "externalSecond" : qUnion([SYVrRslsuWmMiz_query]) });
                    }
                    {
                        var ntcFTVCQuHgBaK_query;
                        ntcFTVCQuHgBaK_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$MRnSsDL0k70RC0M5R4R5R6R7R8RaRbRcRdSc$pHUkbRTbEwS6R4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "oLvPNL3KUD9k.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "oLvPNL3KUD9k.end", "externalSecond" : qUnion([ntcFTVCQuHgBaK_query]) });
                    }
                    {
                        skConstraint(sketch, "sBn2qlbh9JXS.distance", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "localFirst" : "oLvPNL3KUD9k", "localSecond" : "sBn2qlbh9JXS.0", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('BottomHoleInset')), 'expression' : "#BottomHoleInset" }.value, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : -2.388436118761696, "labelDistance" : -0.04481455311179161 * meter, "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        skConstraint(sketch, "sBn2qlbh9JXS.0.offset", { "constraintType" : ConstraintType.OFFSET, "index" : "1", "name" : "", "localOffset" : "sBn2qlbh9JXS.0", "localMaster" : "oLvPNL3KUD9k", "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        skConstraint(sketch, "pJt9DqmTCMvs.centerSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localEntity1" : "pJt9DqmTCMvs.center", "localEntity2" : "sBn2qlbh9JXS.0" });
                    }
                    {
                        skConstraint(sketch, "z9LGxQ4cojph", { "constraintType" : ConstraintType.DIAMETER, "index" : "1", "name" : "", "localFirst" : "pJt9DqmTCMvs", "length" : { 'value' : try(lookup('BoltThrougDiam')), 'expression' : "#BoltThrougDiam" }.value, "labelRatio" : 7.25593879766209, "labelAngle" : -2.7511606083072215 * radian });
                    }
                    {
                        skConstraint(sketch, "bSogARb8m3IL.centerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "bSogARb8m3IL.center", "localSecond" : "pJt9DqmTCMvs.center" });
                    }
                    {
                        skConstraint(sketch, "QVZNBuvTRx3w", { "constraintType" : ConstraintType.DIAMETER, "index" : "2", "name" : "", "localFirst" : "bSogARb8m3IL", "length" : { 'value' : try(lookup('BoltCounterboreDiam')), 'expression' : "#BoltCounterboreDiam" }.value, "labelRatio" : 4.117592649341573, "labelAngle" : 2.9394368983821284 * radian });
                    }
                    {
                        skConstraint(sketch, "XamdLEhmN7Ax.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "XamdLEhmN7Ax.start", "localSecond" : "sBn2qlbh9JXS.0.start" });
                    }
                    {
                        skConstraint(sketch, "vlFXSRHGzSqp", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "XamdLEhmN7Ax", "localSecond" : "sBn2qlbh9JXS.0" });
                    }
                    {
                        skConstraint(sketch, "WnMT0ThIYVpH.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "WnMT0ThIYVpH.start", "localSecond" : "XamdLEhmN7Ax.end" });
                    }
                    {
                        skConstraint(sketch, "ctaa9E53elDq", { "constraintType" : ConstraintType.LENGTH, "index" : "2", "name" : "", "localFirst" : "WnMT0ThIYVpH", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('BoltCounterboreDiam')), 'expression' : "#BoltCounterboreDiam" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.4313556969588573, "labelDistance" : 0.019985632733946934 * meter });
                    }
                    {
                        skConstraint(sketch, "8o4BJkV8eqCs", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "WnMT0ThIYVpH", "localSecond" : "sBn2qlbh9JXS.0" });
                    }
                    {
                        skConstraint(sketch, "7J9X8KfqlZkv", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "bSogARb8m3IL", "localSecond" : "WnMT0ThIYVpH.end" });
                    }
                    {
                        var JJWSjfSbRPDpFB_query;
                        JJWSjfSbRPDpFB_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FEgylpGpriUs7TI_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.1.3$iwYSKckpetWH0end",id);
                        skConstraint(sketch, "oUj9SKXSWzoF.0.project", { "constraintType" : ConstraintType.PROJECTED, "index" : "1", "name" : "", "projectionType" : SketchProjectionType.USE, "localFirst" : "oUj9SKXSWzoF.0", "externalSecond" : qUnion([JJWSjfSbRPDpFB_query]), "sketchToolType" : SketchToolType.USE });
                    }
                    {
                        var lnNzIrqsOvvZrK_query;
                        lnNzIrqsOvvZrK_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$16yyiVBsxS9CC0M5R4R5R6R7R8RaRbRcRdSc$quFEu4ZacbDGR4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "nWHqTrWTFTgT.0.project", { "constraintType" : ConstraintType.PROJECTED, "index" : "2", "name" : "", "projectionType" : SketchProjectionType.USE, "localFirst" : "nWHqTrWTFTgT.0", "externalSecond" : qUnion([lnNzIrqsOvvZrK_query]), "sketchToolType" : SketchToolType.USE });
                    }
                    {
                        skConstraint(sketch, "ulWKLNSoIQU5.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "name" : "", "localFirst" : "ulWKLNSoIQU5.start", "localSecond" : "nWHqTrWTFTgT.0" });
                    }
                    {
                        var HvhEiTwDCTGqoE_query;
                        HvhEiTwDCTGqoE_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$quFEu4ZacbDGR4R5R6R7S7$isStartFR8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "ulWKLNSoIQU5.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "name" : "", "localFirst" : "ulWKLNSoIQU5.end", "externalSecond" : qUnion([HvhEiTwDCTGqoE_query]) });
                    }
                    {
                        skConstraint(sketch, "S3WlzTxA0rHA", { "constraintType" : ConstraintType.LENGTH, "index" : "3", "name" : "", "localFirst" : "ulWKLNSoIQU5", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('RailBlockBoltDepth') + 2 * millimeter + 2 * millimeter + (.5 * lookup('BoltCounterboreDiam'))), 'expression' : "#RailBlockBoltDepth+2mm+2mm+(.5*#BoltCounterboreDiam)" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.626137793831599, "labelDistance" : 0.004506508564949024 * meter });
                    }
                    {
                        skConstraint(sketch, "P0AnCLd2WPTI", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "pJt9DqmTCMvs.center", "localSecond" : "ulWKLNSoIQU5.end" });
                    }
                    skSetInitialGuess(sketch, initialGuessFPs6SSSPjT9zNdc_4);
                    skSolve(sketch);
                }
            };
        try(features.FPs6SSSPjT9zNdc_4(id));
        features.FEK3Z272c7rT83f_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var iWHttpQPaASfnJ_query;
                    iWHttpQPaASfnJ_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FPs6SSSPjT9zNdc_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$pJt9DqmTCMvsR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    var tSRSbGUHicCNLC_query;
                    tSRSbGUHicCNLC_query=qCompressed(1.0,"&197$eJxlT0tvwjAM/jPZcWgplNJjSAPLRh9zcuGE2iaCbCotaWDqfv1CmdCmXSzb38P+HpYhejtrO6ShwAFSpi+byuzPpTPtMSldSXAa/Efk0GmxQDIv8k2+3vpWH51xRvckIAF98m4VUtqai1Yr2zbjpryRhqt4WSJ2H8QMsWTNvORgetfa4ceeAiOS55kH2k7b8TJXywBxRbDAeDJHq6KfCyGKdxl/ZarezT6N1XknYnS6phqNFBKvTNLnHcskl1uhUf+hXX24PcCVqFH34uLk1EiaXnoIYQ4RLCCmtT/zqCYRMk1nzdFBLSLE0wJ4JpNHfEsKs7HeVVBBDQq0t61EuydQLZop3/wi4MAz8DTBENLIh18Ryv5C37Chgyg=",id);
                    annotation { "Feature Name" : "Rear Counterbore" }
                    extrude(context, id + "FEK3Z272c7rT83f_4", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([iWHttpQPaASfnJ_query, tSRSbGUHicCNLC_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(lookup('BoltCounterboreThick')), 'expression' : "#BoltCounterboreThick" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FEK3Z272c7rT83f_4(id));
        features.FV48INIAeeys2lR_5 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var SPefhwnHlMKcAc_query;
                    SPefhwnHlMKcAc_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FPs6SSSPjT9zNdc_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$bSogARb8m3ILR4C6S4$BODYR6R7R8CbA1S11.9$FEK3Z272c7rT83f_4opExtrudeRbSa$SWEPT_BODY",id);
                    var PgTkHJyfjJhoRw_query;
                    PgTkHJyfjJhoRw_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$MRnSsDL0k70RR4R5R6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbS8$CAP_EDGE",id);
                    var LdduAVEgmWQKgV_query;
                    LdduAVEgmWQKgV_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    annotation { "Feature Name" : "Rear CB pattern" }
                    linearPattern(context, id + "FV48INIAeeys2lR_5", { "patternType" : PatternType.PART, "operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([SPefhwnHlMKcAc_query]), "faces" : qUnion([]), "instanceFunction" : try(featureList({})), "directionOne" : qUnion([PgTkHJyfjJhoRw_query]), "distance" : { 'value' : try(lookup('RearHoleSpacing')), 'expression' : "#RearHoleSpacing" }.value, "instanceCount" : { 'value' : try(roundWithinTolerance(3)), 'expression' : "3" }.value, "oppositeDirection" : false, "isCentered" : true, "hasSecondDir" : false, "directionTwo" : qUnion([]), "distanceTwo" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "instanceCountTwo" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "1" }.value, "oppositeDirectionTwo" : false, "isCenteredTwo" : false, "defaultScope" : false, "booleanScope" : qUnion([LdduAVEgmWQKgV_query]), "fullFeaturePattern" : false, "skipInstances" : false, "skippedInstances" : [], "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FV48INIAeeys2lR_5(id));
        features.FTwBQP6EwWNX0Hx_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var mWFSykttKXhvVy_query;
                    mWFSykttKXhvVy_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FPs6SSSPjT9zNdc_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$pJt9DqmTCMvsR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    annotation { "Feature Name" : "Rear through" }
                    extrude(context, id + "FTwBQP6EwWNX0Hx_4", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([mWFSykttKXhvVy_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(10 * millimeter), 'expression' : "10 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FTwBQP6EwWNX0Hx_4(id));
        features.FfRNMhRLtAKP6KJ_5 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var ieznCFnWdWztlc_query;
                    ieznCFnWdWztlc_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FPs6SSSPjT9zNdc_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$pJt9DqmTCMvsR4C6S4$BODYR6R7R8CbA1S11.9$FTwBQP6EwWNX0Hx_4opExtrudeRbSa$SWEPT_BODY",id);
                    var MGDPbjnzBxRffw_query;
                    MGDPbjnzBxRffw_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FPs6SSSPjT9zNdc_4wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$oLvPNL3KUD9k",id);
                    var gSVxlsTmgdhDqW_query;
                    gSVxlsTmgdhDqW_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    var vbJwOjjWdxOGjl_query;
                    vbJwOjjWdxOGjl_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    annotation { "Feature Name" : "rear cb cut" }
                    linearPattern(context, id + "FfRNMhRLtAKP6KJ_5", { "patternType" : PatternType.PART, "operationType" : NewBodyOperationType.REMOVE, "entities" : qUnion([ieznCFnWdWztlc_query]), "faces" : qUnion([]), "instanceFunction" : try(featureList({})), "directionOne" : qUnion([MGDPbjnzBxRffw_query]), "distance" : { 'value' : try(lookup('RearHoleSpacing')), 'expression' : "#RearHoleSpacing" }.value, "instanceCount" : { 'value' : try(roundWithinTolerance(3)), 'expression' : "3" }.value, "oppositeDirection" : false, "isCentered" : true, "hasSecondDir" : false, "directionTwo" : qUnion([]), "distanceTwo" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "instanceCountTwo" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "1" }.value, "oppositeDirectionTwo" : false, "isCenteredTwo" : false, "defaultScope" : false, "booleanScope" : qUnion([gSVxlsTmgdhDqW_query, vbJwOjjWdxOGjl_query]), "fullFeaturePattern" : false, "skipInstances" : false, "skippedInstances" : [], "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FfRNMhRLtAKP6KJ_5(id));
        features.F8bAfNLNMmtCwoP = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "F8bAfNLNMmtCwoP", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "UpperRoundDiam", "lengthValue" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F8bAfNLNMmtCwoP(id));
        features.F0ojtvzA0SnUbVw = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "F0ojtvzA0SnUbVw", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "LowerRoundDiam", "lengthValue" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F0ojtvzA0SnUbVw(id));
        features.FS9JeCV4ZJ73ITL = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FS9JeCV4ZJ73ITL", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "UpperChamfer", "lengthValue" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FS9JeCV4ZJ73ITL(id));
        features.FVqM2a0ZwWHLhqz = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    annotation { "Feature Name" : "###name = #value" }
                    assignVariable(context, id + "FVqM2a0ZwWHLhqz", { "initEntities" : qUnion([]), "mode" : VariableMode.ASSIGNED, "variableType" : VariableType.LENGTH, "measurementMode" : VariableMeasurementMode.DISTANCE, "name" : "LowerChamfer", "lengthValue" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "angleValue" : 0.0 * degree, "numberValue" : 0.0, "anyValue" : { 'value' : try(0), 'expression' : "0" }.value, "value" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "csv" : {} as TableData, "rowAccessType" : AccessType.INDEX, "rowIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowValue" : "", "rowRegexp" : false, "rowMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "rowResult" : ResultType.SINGLE, "rowLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnAccessType" : AccessType.INDEX, "columnIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnValue" : "", "columnRegexp" : false, "columnMinIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnMaxIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "columnResult" : ResultType.SINGLE, "columnLabelIndex" : { 'value' : try(roundWithinTolerance(0)), 'expression' : "" }.value, "useConversionFactor" : false, "conversionFactor" : { 'value' : try(0), 'expression' : "0" }.value, "entityCouple" : qUnion([]), "minmax" : VariableMinMaxSelection.MINIMUM, "extendEntities" : false, "measureFromAxis" : false, "distance" : 0.0 * meter, "xOffset" : 0.0 * meter, "yOffset" : 0.0 * meter, "zOffset" : 0.0 * meter, "componentSelector" : AxisWithCustom.DISTANCE, "customDirection" : qUnion([]), "customOffset" : 0.0 * meter, "lengthEntities" : qUnion([]), "radius" : false, "diameterEntity" : qUnion([]), "description" : "", "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FVqM2a0ZwWHLhqz(id));
        features.FCjQYeNCXzbMZup_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (!switch (configuration.List_sltuiwY7bs5tJx) { List_sltuiwY7bs5tJx_conf.Default : false, List_sltuiwY7bs5tJx_conf.Round : true, List_sltuiwY7bs5tJx_conf.Bevel : true })
                {
                    {
                    }
                    var ibUrRawdYGmUxm_query;
                    ibUrRawdYGmUxm_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$16yyiVBsxS9CC0M5R4R5R6R7R8RaRbRcRdSc$MRbBneG7tRe9R4R5R6R7R8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$SWEPT_EDGE",id);
                    var dkkhYVmmVvlymg_query;
                    dkkhYVmmVvlymg_query=qCompressed(1.0,"&25d$eJxtkEtzozAQhP+M9pgUwgbDkYd4rAMmI2pTzoUCNImFY0QAJ+HfL9hbSdUmR82Mur/uX65B7s/YT4nBKyKwl28ogl6dHN3T5hnViZBDeark87kcpWr9ciwdmujfN/nUIacrsoM4jFPnrvBZxlKfpd6e20T18lm25cvwT7gk2I5ynJZfbknY54OvCfNDNtMc5DCq/jq0iAfMyeNdOi9Uh/3FMhauTmLhUE7prUkCGQ6Nw9dbU7PKp7rQ3mWPu252f10iXoQE4VuWe1HB0jzO9xzJcMSxPlwBYsFrwqMqqK3THjHdLKxggAkbsMCGCmoQgPORv0p+102G0eMOvw68+spikyAJDv7TvnnVm+3ZSQpNdexj7M8CoZ7D8weW5cUS9OJAl0pBhxWsr/18l7xBEqjpqEuaiIe87e4Ohf5JQ81pkn/c4YPb3n/I9Is5gcptMdyMgPYPBnRusFnDxo1HpaJTNGUXB2r9mE93XUPzj/lWZQ2axUp1rlIvWLZzPoMkDEL2F/PfvwM=",id);
                    var fZBdOaYapZcllD_query;
                    fZBdOaYapZcllD_query=qCompressed(1.0,"&25d$eJxtkEtzozAQhP+MctwUkgGbIw+BKRvsHZE4zoWSkRILxwjz2A3/PmBvJVWbHDUz6v667zwL/e5lMyQWOyAhG/VHirDRZ5f4xjjDBAnV8vNBvfa8U7oKeMddnJDvm2yoJcMztIE4ilN3nQd0S9OApv6eOUg36lVV/K39J8yRrDrVDdMvjyP6+WAmokFER5qjajvd3IYL5AN1s3iTjgtdy+ZqGQuPoFi4mGF8b6NQRW3pMnNlGwv+UuTGX9XITT26X6aIVyGB2Ipm/jKnaRZneyZRe5JdcbwBxIIV6GFjOLsye7Ltx3ZiBQtsmMMCHDhAAQLkeJRAxdpgbZzmBnwd+MWNxUFhEh6Dl315IeWqd5Pc0DV975peSCjG8GxHt1k+Bb064KlSIDAD89bPd8lfEoV6OBGFE7HLqnp9zMknDbaHQT167Ttz/P+Q8RfzpQ9pbz7z4hBEPxjgscHShLkXd1ovz8the3XAix/zEc+zjOCUrfS2lHY+07Wn9Zvk1ZjPQgmFiH4Afs2+vQ==",id);
                    var XbWGkXxnvouRTW_query;
                    XbWGkXxnvouRTW_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$16yyiVBsxS9CC0M5R4R5R6R7R8RaRbRcRdSc$quFEu4ZacbDGR4R5R6R7R8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$SWEPT_EDGE",id);
                    annotation { "Feature Name" : "Fillet 1" }
                    fillet(context, id + "FCjQYeNCXzbMZup_4", { "filletType" : FilletType.EDGE, "entities" : qUnion([ibUrRawdYGmUxm_query, dkkhYVmmVvlymg_query, fZBdOaYapZcllD_query, XbWGkXxnvouRTW_query]), "side1Face" : qUnion([]), "side2Face" : qUnion([]), "centerFaces" : qUnion([]), "tangentPropagation" : true, "blendControlType" : BlendControlType.RADIUS, "crossSection" : FilletCrossSection.CIRCULAR, "radius" : { 'value' : try(lookup('Upper_Round')), 'expression' : "#Upper_Round" }.value, "nonCircularRadius" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "width" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "rho" : { 'value' : try(0.5), 'expression' : "0.5" }.value, "magnitude" : { 'value' : try(0.5), 'expression' : "0.5" }.value, "defaultsChanged" : true, "isAsymmetric" : false, "otherRadius" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipAsymmetric" : false, "isPartial" : false, "startPartialType" : EndTypePartialFillet.PERCENTAGE, "startPartialOffset" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "startPartialEntity" : qUnion([]), "partialFirstEdgeTotalParameter" : { 'value' : try(0.01), 'expression' : "0.01" }.value, "partialOppositeParameter" : true, "useTrimmedFirstBound" : false, "secondBound" : false, "endPartialType" : EndTypePartialFillet.PERCENTAGE, "endPartialOffset" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endPartialEntity" : qUnion([]), "useTrimmedSecondBound" : false, "partialSecondEdgeTotalParameter" : { 'value' : try(0.99), 'expression' : "0.99" }.value, "isVariable" : false, "vertexSettings" : [], "pointOnEdgeSettings" : [], "smoothTransition" : false, "allowEdgeOverflow" : true, "keepEdges" : qUnion([]), "smoothCorners" : false, "smoothCornerExceptions" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FCjQYeNCXzbMZup_4(id));
        features.FHv2owCyBFFehgs_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var tGkauQXmiKwCKu_query;
                    tGkauQXmiKwCKu_query=qCompressed(1.0,"&25d$eJxtkFtTo0AQhf/M7KMWQwIhj1yGS0UI28OulScKmFaGGAaBqPx7IbG0Sn2c7p5zvnP+OAb5e8Z+ig1eEoG9fEHh9+pk6642z6hOhByKUykfz8UoVesVY2HTWP+5yaYOOV2RPURBlNh3ucdSlngscQ98S1QvH2VbPA0fwgXBdpTjtPxyCsI+H3xNmBewmaaWw6j669AiLjA7i/bJvFAd9hfLSDg6iYRNOaW3JvFlMDQ2X+9MzSoeqlx7lT3uu9n9eYl4ERKE71jmhjlLsig7cCTDEceqvgJEgleEh6VfWacDYrJZWMEAEzZgwRZKqEAAzkdd+O9YQlayV25+HbjVlWVL/NivvYdD86w3u7Md55rq2NvYnwVCNYfn9yzN8iXoxYEulYIOK1hf+/kpeYPEV9NRlzQW91nb3dW5/kkTQ+m0GGxGwO03ZPrF3Hb4UsvgfyoY/cWAzg02a9g40ahUeAqn9OJArV/z6Y5jaN4x26m0QTNfqc5R6gmLds5nkJhBwN4BVrm/gQ==",id);
                    var AiXGLyOWFQOWgU_query;
                    AiXGLyOWFQOWgU_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$MRbBneG7tRe9C0M5R4R5R6R7R8RaRbRcRdSc$npevhiGVPdE1R4R5R6R7R8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$SWEPT_EDGE",id);
                    var uhgSzsuMkzrXfn_query;
                    uhgSzsuMkzrXfn_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$npevhiGVPdE1C0M5R4R5R6R7R8RaRbRcRdSc$quFEu4ZacbDGR4R5R6R7R8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$SWEPT_EDGE",id);
                    var WvCRAfSydTDvPZ_query;
                    WvCRAfSydTDvPZ_query=qCompressed(1.0,"&25d$eJxtkEtzozAQhP+M9pgthAHbRx4CUzaYHbGb8l4ogZQgiBHmkYR/H7C34qpNjpoZdX/dPxwT/RpFN0UmzREXnXwV3O/U2dZdbZ5hHXHZs3Mun0c2SNV4bGA2jvSvm3RqBcUrdIQwCGP7kHkkIbFHYvdEt0h18lk27KX/J8yQaAY5TMsvhyHy+aAGIl5AZppS9oPqbsMNcoHYaXiM54VqRXe1DLmjo5DbmGL800K+DPrKpsbe0jbsqci0N9mJYzu7X5aIVyGO6J6k7i4jcRqmJypQX4uhKG8AIacFiqChvXfQ6rUGCyuYYMEaNrCFHArgIOajdve7ziHNyRu17gducWPZIj/yS+/pVF30aj/aUaaplrwP3cgFFHN4+kiSNFuCXh3wUinosALj1s9XyQeBfDXVusQRf0yb9lBm+idN04rXUgZ/Ek7wf8j4znwZfTIaf1mRe8E3BnhusDJg7YSDUrvzbkquDnjzbT7dcUzNq9O9SiphZSvVOkq9CNbM+UwUEQjIBy0Jv3I=",id);
                    annotation { "Feature Name" : "Fillet 2" }
                    fillet(context, id + "FHv2owCyBFFehgs_4", { "filletType" : FilletType.EDGE, "entities" : qUnion([tGkauQXmiKwCKu_query, AiXGLyOWFQOWgU_query, uhgSzsuMkzrXfn_query, WvCRAfSydTDvPZ_query]), "side1Face" : qUnion([]), "side2Face" : qUnion([]), "centerFaces" : qUnion([]), "tangentPropagation" : true, "blendControlType" : BlendControlType.RADIUS, "crossSection" : FilletCrossSection.CIRCULAR, "radius" : { 'value' : try(lookup('LowerRoundDiam')), 'expression' : "#LowerRoundDiam" }.value, "nonCircularRadius" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "width" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "rho" : { 'value' : try(0.5), 'expression' : "0.5" }.value, "magnitude" : { 'value' : try(0.5), 'expression' : "0.5" }.value, "defaultsChanged" : false, "isAsymmetric" : false, "otherRadius" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipAsymmetric" : false, "isPartial" : false, "startPartialType" : EndTypePartialFillet.PERCENTAGE, "startPartialOffset" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "startPartialEntity" : qUnion([]), "partialFirstEdgeTotalParameter" : { 'value' : try(0.01), 'expression' : "0.01" }.value, "partialOppositeParameter" : true, "useTrimmedFirstBound" : false, "secondBound" : false, "endPartialType" : EndTypePartialFillet.PERCENTAGE, "endPartialOffset" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endPartialEntity" : qUnion([]), "useTrimmedSecondBound" : false, "partialSecondEdgeTotalParameter" : { 'value' : try(0.99), 'expression' : "0.99" }.value, "isVariable" : false, "vertexSettings" : [], "pointOnEdgeSettings" : [], "smoothTransition" : false, "allowEdgeOverflow" : true, "keepEdges" : qUnion([]), "smoothCorners" : false, "smoothCornerExceptions" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FHv2owCyBFFehgs_4(id));
        features.FRwPt9qVczpM9nA_4 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (!switch (configuration.List_sltuiwY7bs5tJx) { List_sltuiwY7bs5tJx_conf.Default : true, List_sltuiwY7bs5tJx_conf.Round : true, List_sltuiwY7bs5tJx_conf.Bevel : false })
                {
                    {
                    }
                    var xYkneduGiXYIoT_query;
                    xYkneduGiXYIoT_query=qCompressed(1.0,"&25d$eJxtkEtzozAQhP+M9pgUwgbDkYd4rAMmI2pTzoUCNImFY0QAJ+HfL9hbSdUmR82Mur/uX65B7s/YT4nBKyKwl28ogl6dHN3T5hnViZBDeark87kcpWr9ciwdmujfN/nUIacrsoM4jFPnrvBZxlKfpd6e20T18lm25cvwT7gk2I5ynJZfbknY54OvCfNDNtMc5DCq/jq0iAfMyeNdOi9Uh/3FMhauTmLhUE7prUkCGQ6Nw9dbU7PKp7rQ3mWPu252f10iXoQE4VuWe1HB0jzO9xzJcMSxPlwBYsFrwqMqqK3THjHdLKxggAkbsMCGCmoQgPORv0p+102G0eMOvw68+spikyAJDv7TvnnVm+3ZSQpNdexj7M8CoZ7D8weW5cUS9OJAl0pBhxWsr/18l7xBEqjpqEuaiIe87e4Ohf5JQ81pkn/c4YPb3n/I9Is5gcptMdyMgPYPBnRusFnDxo1HpaJTNGUXB2r9mE93XUPzj/lWZQ2axUp1rlIvWLZzPoMkDEL2F/PfvwM=",id);
                    var pwAfDyGKAyxlDl_query;
                    pwAfDyGKAyxlDl_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$16yyiVBsxS9CC0M5R4R5R6R7R8RaRbRcRdSc$MRbBneG7tRe9R4R5R6R7R8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$SWEPT_EDGE",id);
                    annotation { "Feature Name" : "Chamfer 1" }
                    chamfer(context, id + "FRwPt9qVczpM9nA_4", { "entities" : qUnion([xYkneduGiXYIoT_query, pwAfDyGKAyxlDl_query]), "chamferMethod" : ChamferMethod.APEX_RANGE, "chamferType" : ChamferType.EQUAL_OFFSETS, "width" : { 'value' : try(lookup('Upper_Chamfer')), 'expression' : "#Upper_Chamfer" }.value, "width1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeDirection" : false, "width2" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "angle" : { 'value' : try(45 * degree), 'expression' : "45 deg" }.value, "directionOverrides" : qUnion([]), "tangentPropagation" : true, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FRwPt9qVczpM9nA_4(id));
        features.FxmAnBYEqBearOn_5 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var guHdAaQmyUbVve_query;
                    guHdAaQmyUbVve_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    var kVFTwwfEPNMard_query;
                    kVFTwwfEPNMard_query=qCompressed(1.0,"&212$eJx1kFtzgjAQhf9M+toBRS6PEAJiBW3C2OILEySDgcolBC399RWd6UuHx939ds/Z8+KswPvAxBjqRF2AnPf0kvFioJI3tUsltdVw8X8Sjy0j6hLscOAHkb1NXbRHkYsimBALNIIXvKZfva1DJVwRClgtuRynLYcC9FcQDSDXRyQDZ97LRjybJoAY2XGwi+6DpmXiIRnkzgIEua0SVX3VgRd1or/6Bz9UjlXmpssbF2zX3tW76Z3HoRyQNxTDdYqiOIgTwkBfMXk6Pw0EOTkBCCOz83yWXzpv8oo1vMI6NrCJKc7wCU/Q7dCRa1x6tVCsWWipqUFxS8p23P7MQnlVtsqhdpp+/J6F2IdSnrHNEJPJvNyRXkbqsM/MW2MN6vcoPRuiiSMG4D2RVMgYmzB7JmYBbyh6qq4tveLGZmOky6ZF31IMOcPZlLm9T6cLv84dq8s=",id);
                    var yZZbBlDLhxxZZH_query;
                    yZZbBlDLhxxZZH_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    annotation { "Feature Name" : "Mirror 1" }
                    mirror(context, id + "FxmAnBYEqBearOn_5", { "patternType" : MirrorType.PART, "operationType" : NewBodyOperationType.NEW, "entities" : qUnion([guHdAaQmyUbVve_query]), "faces" : qUnion([]), "instanceFunction" : try(featureList({})), "mirrorPlane" : qUnion([kVFTwwfEPNMard_query]), "defaultScope" : false, "booleanScope" : qUnion([yZZbBlDLhxxZZH_query]), "fullFeaturePattern" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FxmAnBYEqBearOn_5(id));
        features.FzkZ4gkOSDjkkKC_5 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var cwfilNXbULYYhl_query;
                    cwfilNXbULYYhl_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    var auLstyXNJcsuWy_query;
                    auLstyXNJcsuWy_query=qCompressed(1.0,"&266$eJx1UUuPmzAQ/jPutcJJIOHIwxC2G0htlC17QQaPEifFgHEe7K8vSaRKVZXjzHyvmfnm2+jnGfS4cViFBGh5ARHptgmsjc3wDAk58KaS+zM3slUhN9zDm9n/k3zsgOE5ymgSJ6n3XoZkS9KQpEHBXNRquZeK/x485yHMESgjzXhn+RyRvwVbIBLGZMpykINp9bO5QgElXp5k6TRoO9APy0T4M5QIDzOMvzsoSns9XOJdvLE+T1VYzq9SQ9ZN7v19wYeQQOwHyYN1SdI8yQsGaDiBqQ/PAIlgNQqCdNVHMYimj+5ZqU0duqQr6tKK1lRQmEDXXc8u+TFS2nJfguYLnOyvxbEb379egsTp2Fk75bfDeHsJgg/reKAeEDDFa7tP3ozch19VtKZ2sJxO6Wdh8cQF9fNMLorO+4Hjteuc5PLtbVnO247cjD4LoPX0F/ZBtnn5INoUw509aUs1GK5qSHkzfRnhfwRvjaf8gvQ+cJ2p0m67LTcGtJoEFyjItsUfypDHug==",id);
                    annotation { "Feature Name" : "2x tab connect" }
                    booleanBodies(context, id + "FzkZ4gkOSDjkkKC_5", { "operationType" : BooleanOperationType.UNION, "tools" : qUnion([cwfilNXbULYYhl_query, auLstyXNJcsuWy_query]), "targets" : qUnion([]), "offset" : false, "offsetAll" : false, "entitiesToOffset" : qUnion([]), "offsetDistance" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeDirection" : false, "reFillet" : false, "keepTools" : true, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FzkZ4gkOSDjkkKC_5(id));
        features.FpM4aaNeFR9KTOs_6 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var uxGDiSgFBAdbjG_query;
                    uxGDiSgFBAdbjG_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    var nBANdNSxdUsOKL_query;
                    nBANdNSxdUsOKL_query=qCompressed(1.0,"&1bf$eJx1kMtugzAQRX9muq1qSggseTgUNTxqW0TpBhlsBSstEDBt+PtCkLKpspyZM3funSdvAx+j7Kd4Q5EBQg38u1SnkWvVNgHX3EWx8X/Cpk5S9AopicIocfdFgDOcBDjxj9SBtlcn1fCvwTX9l1mYg2y00tOy5XHA94KagIMQ0xJqNei2X5s2+AS7LEqTedB2sr+djIRnQCRcRBF6tmDXTmdDoVgcWNPt68L4Vb1Mu/n6ZYlzExJA3zHz3wqcsIgdqYThLHVVrwYiQStA1jSp3Buu1PEXr8QkG2KRLbEJJyWpyALFpPQaGW41kc5DqOnkT63CPBMYPYQu4w6P5ievyiAkpm/ND/DS4LhyfrmGc2AX2mY+5qEt64w1fWG2Hb7qfhSSlPM36QFnrFgW/wAFbZHQ",id);
                    annotation { "Feature Name" : "endcap tab connect" }
                    booleanBodies(context, id + "FpM4aaNeFR9KTOs_6", { "operationType" : BooleanOperationType.UNION, "tools" : qUnion([uxGDiSgFBAdbjG_query, nBANdNSxdUsOKL_query]), "targets" : qUnion([]), "offset" : false, "offsetAll" : false, "entitiesToOffset" : qUnion([]), "offsetDistance" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeDirection" : false, "reFillet" : false, "keepTools" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FpM4aaNeFR9KTOs_6(id));
        features.F1AiqOmUxEkecER_6 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (false)
                {
                    {
                    }
                    var XpOXTNccUcmfcx_query;
                    XpOXTNccUcmfcx_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    var rleHkHJVRQriOK_query;
                    rleHkHJVRQriOK_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    var FWbPtMHbqSeeNO_query;
                    FWbPtMHbqSeeNO_query=qCompressed(1.0,"&293$eJyFkN2OmzAQhV/GvewKQ8yGSwOG0PBXG2lLb5ADJnE2G8CQbbJPX4c0VapW6p09c2bOme+Ti8DXk1CXxGYb0Agl30UTqO7NMxLEoAkaOfK3jdye+CS7o88njmFi/t0pLr1g0AIZjcIoxXHlk5ykPkm9kjmgU3Irj/wwYnNezIE4TnK6XKdcDsjvD1sA4odEZ9nJcerUrbgEHiW4iLJUN7peqNkyalwTRA2GDMInGwQyHPeYLda2seRtXRk/pBJZr92H64HzogawNSm8VUXSIipKJsD4KqZ6dwsQNawG9SZOkkPh98OHf81KEbXpM11Sh25oTRsqtMje1l++ZRNtx+SVIu9Zxw6wR246r75FckCQBDu/LfeDuV+fcFIZXU/Okzo1gtaaAXsheVHNg/BKlZr60iLLszgLS/2cGUnxC9pdQy26wPDPaHfLzwIE1spH+bm0MFZOHlbWPfSTBcbEeY9XLwjxyJu6Xs/D+21wqXXQ+Z/RA4MgPCvifXx30H74x6aH0gOQQZjG2mzdbe6vUFtZXe923UHwowaCAMvjqPgJsmPNSg==",id);
                    var LBWFMQwmhaonId_query;
                    LBWFMQwmhaonId_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$FGxrECzZ95jqR4C6S4$FACER6R7R8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$SWEPT_FACE",id);
                    var RNXIMgcKRuvitf_query;
                    RNXIMgcKRuvitf_query=qCompressed(1.0,"&205$eJxlkFtzgjAQhf9M+tohKKiPXAJmkEsTZjr2hYkkaKwaCNjW/vpGtB1n+pbsnt3znX3yHfByFvqSunQDuNDyQ/BIq2NgpQ6FNuCyZ8eN3J7ZINUpZAPzYGr/75SXVlA4ATnBMc68VRWiAmUhyoI1XQCl5Vae2KH34LiYAXEa5HC5TvkMoL8PnQIUxsiw7GQ/KH0rzkFAkFfiPDMN1Qo9WmLu2wBzD1IIn10Qybjfe3SauNacNXVlfUot8ta4d9eA4yIOaILKYFmhrMTlmgrQv4uh3t0AMKc1oAq3l6Y4JE73TZxgZogiL0BkRuZkEdQ3twWI0mgXNut9Z++Ts5dWlmrR16DPXJDaxKOvqCircRBeD0ZsE6LMi3yVx2vzHONLcb/Hr4ZMyPRecYh7syQbUhNOhEGL4i+Ngu+3hbPvjABO7wroGgmcPZQeODthW4nd+NsiXDpNNVGtr9RBsJPhdAAtVrj8AR33pM0=",id);
                    var qbPysEqnCIkWgJ_query;
                    qbPysEqnCIkWgJ_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSd.8$LhC2jMEYbjYG0MirrorCSR4C6S4$FACER6R7R8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$SWEPT_FACE",id);
                    var CKFlQAfHRRPtTl_query;
                    CKFlQAfHRRPtTl_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$sM9vLHW55aICtopR4C6S4$FACER6R7R8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$SWEPT_FACE",id);
                    annotation { "Feature Name" : "endcap tab sizing" }
                    booleanBodies(context, id + "F1AiqOmUxEkecER_6", { "operationType" : BooleanOperationType.SUBTRACTION, "tools" : qUnion([XpOXTNccUcmfcx_query]), "targets" : qUnion([rleHkHJVRQriOK_query]), "offset" : true, "offsetAll" : false, "entitiesToOffset" : qUnion([FWbPtMHbqSeeNO_query, LBWFMQwmhaonId_query, RNXIMgcKRuvitf_query, qbPysEqnCIkWgJ_query, CKFlQAfHRRPtTl_query]), "offsetDistance" : { 'value' : try(0.05 * millimeter), 'expression' : "0.05 mm" }.value, "oppositeDirection" : false, "reFillet" : false, "keepTools" : true, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F1AiqOmUxEkecER_6(id));
        features.FtBciP4FdsrYK6w_6 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFtBciP4FdsrYK6w_6 = { "xd65N6p5IcqJ.bottom" : [0.01524, -0.0969681236773729, -1.0, 0.0, -0.01524, 0.01524], "xd65N6p5IcqJ.top" : [0.01524, 0.0315318763226271, -1.0, 0.0, -0.01524, 0.01524], "xd65N6p5IcqJ.left" : [0.03048, -0.032718123677372896, 0.0, 1.0, -0.06425, 0.06425], "xd65N6p5IcqJ.right" : [0.0, -0.032718123677372896, 0.0, 1.0, -0.06425, 0.06425] };
                    {
                    }
                    var zIerdIsVyrfNgZ_query;
                    zIerdIsVyrfNgZ_query=qCompressed(1.0,"&27b$eJx9Ud1zojAQ/2f2HnUIAupjhKCZlg+T9KpPTIBY0juFBrzT/75BOzfOdObeNrv7+8r+WPmwPStzTXyOXKh1L4+lfjvLQbenSA4Su4n7fSKuneJoBhmja5ri5yIiOUkjkoZ7voTW6Dd9kr97jELHEktQp0EP1xG1kkD+PbgHJFoTXkKj+6E19+YCQkawoFlqB22nzE2S1isXaI0RR2gaQDzbRH5+2c8wNst8Xcz+aqOyzqp/jHFuRDXwJyLCTUFSQcWeK+h/qaFq7gZozevpAipU9dSSvSy3npNoY1oTcpu5hFoZ/UfVsWmPtyABQy47MAejxGXI2hRZnj1n670tbwG16rGL3TGzXf0qPOazgM3ZgklWsoqNqhP7dRQ3243f1dWulY6l9cKAB/CTMEF2d0BY2rCTajoHfeyMPg2stPFoKgjjJBQRepBih/+KzVberrlQHpQyc+wWWnytoXEPldEEPWDHJp8DTXJm1WzUAwj2Qh6OfHPrQYxD8uDVHmYJcRI30WH//uG+P51xUjhtRy6DOdfKkkrgryQXxQj8BJ2LxM0=",id);
                    annotation { "Feature Name" : "panel" }
                    var sketch = newSketch(context, id + "FtBciP4FdsrYK6w_6", { "sketchPlane" : qUnion([zIerdIsVyrfNgZ_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "xd65N6p5IcqJ.bottom", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "xd65N6p5IcqJ.top", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "xd65N6p5IcqJ.left", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "xd65N6p5IcqJ.right", { "construction" : false, "index" : "4" });
                    {
                        var vLrUfXUIHZnfsn_query;
                        vLrUfXUIHZnfsn_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSd.8$c1csI3HDU9Q40MirrorCSC0M5R4R5R6R7R8RaRbRcRdSd.-13$9mwv8ZyL37Ap0R4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "xd65N6p5IcqJ.firstSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "xd65N6p5IcqJ.bottom.start", "externalSecond" : qUnion([vLrUfXUIHZnfsn_query]) });
                    }
                    {
                        var QQglPXJZxlUKUn_query;
                        QQglPXJZxlUKUn_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6$sM9vLHW55aICbottomC0M5R4R5R6R7R8RaRbRcRdS-12.4$leftR4C6S6$VERTEXR6R7S7$isStartTR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "xd65N6p5IcqJ.oppositeSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "xd65N6p5IcqJ.top.end", "externalSecond" : qUnion([QQglPXJZxlUKUn_query]) });
                    }
                    {
                        skConstraint(sketch, "xd65N6p5IcqJ.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "xd65N6p5IcqJ.top", "localSecond" : "xd65N6p5IcqJ.left" });
                    }
                    {
                        skConstraint(sketch, "xd65N6p5IcqJ.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "xd65N6p5IcqJ.bottom", "localSecond" : "xd65N6p5IcqJ.top" });
                    }
                    {
                        skConstraint(sketch, "xd65N6p5IcqJ.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "xd65N6p5IcqJ.left", "localSecond" : "xd65N6p5IcqJ.right" });
                    }
                    {
                        skConstraint(sketch, "xd65N6p5IcqJ.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "xd65N6p5IcqJ.top" });
                    }
                    {
                        skConstraint(sketch, "xd65N6p5IcqJ.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "xd65N6p5IcqJ.bottom.start", "localSecond" : "xd65N6p5IcqJ.left.start" });
                    }
                    {
                        skConstraint(sketch, "xd65N6p5IcqJ.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "xd65N6p5IcqJ.bottom.end", "localSecond" : "xd65N6p5IcqJ.right.start" });
                    }
                    {
                        skConstraint(sketch, "xd65N6p5IcqJ.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "xd65N6p5IcqJ.top.start", "localSecond" : "xd65N6p5IcqJ.left.end" });
                    }
                    {
                        skConstraint(sketch, "xd65N6p5IcqJ.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "xd65N6p5IcqJ.top.end", "localSecond" : "xd65N6p5IcqJ.right.end" });
                    }
                    skSetInitialGuess(sketch, initialGuessFtBciP4FdsrYK6w_6);
                    skSolve(sketch);
                }
            };
        try(features.FtBciP4FdsrYK6w_6(id));
        features.F8ZIHMXrr0E0Kx9_6 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var loFtRpDMsvDdNM_query;
                    loFtRpDMsvDdNM_query=qCompressed(1.0,"&39c$eJyNUU132jAQ/DPbIzxL/gAfjS2DSzDOym3DiWcsJSgN2JFNA/++MpBQGvpeb9LOzs7s7JeRC/c7qQ8zlxMKQjXFZqWedkWrqm1UtEVAZvQzkh9qyYeQz7P53Xy8ME+5bVWrZBM4AQ0tM20FQmr1S4pYV5tjpTg1HTryqAD28eEOsGjMDGWtmrbSh/P4EFmQJ/PUAFUt9VE5ESMKiQgIJ6TvQdyOSpU5sWj0Yuq9Lb03peW85j68dlsdBwngU5aHkyVL8yRfcAnNT9mW65OBRPCyb8NeeG7q1W5Svn5tqxpd9HCAQ/TD0mj1RH8AalNrtW2x5ANIZhkmaR6R47YeOt2GFxKusESBkveI3XfgRT62aHVRIkGKdkBPIeE5rHeMExvmmIyTNLhbRixjacTScGG2qbR6UtvipTkTru2ZKHoSYnsSudl+YQeB9rPx0j57EP0hJMH6fuLWonyoCmumtK50yP/yTMoPQo9aUJKySczIb/69Y30W9CGexevocfH8Sp+nu2C2tKqa7Vu9E9JEVAD/wbJ82R0WyRDdcMA9+M4wZw/vetT0+WBiZMhZmEc9cokFiXWkIfX/aEdaILny3BWJbYr/cQgXTIrrf14C6QDtwS1JWl4bu91109iF2o2/hR+jcSAOQnaN/QYjuxIS",id);
                    var mxwJuqusxlSJsO_query;
                    mxwJuqusxlSJsO_query=qCompressed(1.0,"&3d0$eJx9UltzojAU/jPZRx3CTXlECJq1XHrC7uqTgyTWdKtgwK3++w1qu7banWEGcs53Ozl8GznocS/UMXYYNhGXTbFZyqd90cpqGxZt4ePYvO3kx1qwIcrTLH1Ix3P9KbatbKVofNs3AyN22RJxoeQfwSNVbXTFYcUZdOzIowKR9wOzEQnHRFPWsmkrdbzIB0D8nKaJblS1UCdnykcmotzHDOO+i6J2VMrMjnij5lP3deG+SiXSmnlo1011EuKITUkeTBYkyWk+ZwI1v0Vbrs8BKGdl30YH7jqJWzu03H1/EasWjG5ywGCC5ZunmRywL+9Lj2ELpUDHNPEfFiHJSBKSJJhr80rJJ7ktXpoLwQEXBjAELyjPyXsCRdYkdLLD3PJ95WXjhQUlcNBx+0NE/fXjxKl5OasKI5ZKVSpgH5UA2++EHl6iEpcN1ZI/vEfbuDX0UBRH63A1f96Zz9O9Hy+MqiaHVu25gFLvhv0iWb7o9gBY84MBc9FPAjmZXQn1eH+A5KZWcttqlodokhNgJMhDfP+OAOtH3x/g4f/zWyN7tj5Q5i6L1LiGcQ3D4hQKTHypmt1tmXbYw1fQrsgGiMYZ6FxguudfEexPzsuLcQ9bfQfpVa2/XDfgFVjeHec39TPK5F+gLONTPrAcXXyjdvK3/X/SnfA9/mk/Nor8gHzs/QUKmh93",id);
                    var FICgjGUQTEKSny_query;
                    FICgjGUQTEKSny_query=qCompressed(1.0,"&39f$eJyNUctymzAU/Rl1aQ8SL7PEIBzqGMgVbcOKwUiJlcbGEbix/74CP1I37kx3oHPP4577ZWqjh51Qh4XNMEFcttV6KZ93VSebTVh1lY8X5DOSH7aCTVCeZul9Oiv0p9h0spOi9S2fBIZWWyIulPwleKSa9fBSHYcOPXlaIXr5YRai4Yxqykq2XaMOJ/kAqJ/HaaKBZivU4BzzKUEx9zHDeOygqJvWMrMi3qpi7ryXzrtUIt0yD731Ww1CHLE5zYO7kiZ5nBdMoPan6OrVMUDMWa2F9tyxE2drx/Xb12XTdc0abHDAhQl4Qa3tRnzsIrneKrnpoGYuihcZxEkejvCwsQNWv+UHC5ZQAwfBRtgcW+hVPHVg9HUCBgKmT45FwamwM8awiVKIZ3Hi35chzWgS0iQo9EaNks9yU722J8J1Pl3HSKDIvAvtbF+Yvq+8bFaapwx8PEE1rttY49+8B8tYSKUaFbC/MuP6QhgRA5lT63G1j5mzrFLjs6GHokW0Cp+KlzfyMt/5i9JotnTfqR0XuqMKsR80y8v+uIAnYAcuc9B3Cjl9PPsRPech3SMFRoM8xB+tADYGFhDvj2kgFeCryP0jNoHU/3EHG+kSV/88BBAXTPeW5Un9Euz21M1g2D5Te/lbwYdmLBT5Ab3GfgPJTRL9",id);
                    annotation { "Feature Name" : "panel thick" }
                    extrude(context, id + "F8ZIHMXrr0E0Kx9_6", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([loFtRpDMsvDdNM_query, mxwJuqusxlSJsO_query, FICgjGUQTEKSny_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F8ZIHMXrr0E0Kx9_6(id));
        features.FlpU4qVtZLrTCze_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFlpU4qVtZLrTCze_7 = { "XSwj11pP1k2S.0" : [0.01524, 0.0285318763226271, -1.0, 0.0, -0.01524, 0.01524], "RNpxngWM4G2P.0" : [0.0075, -0.032718123677372896, 0.0, 1.0, -0.06425, 0.06425], "k6rvhYKhhZUV" : [0.01524, -0.032718123677372896, -0.2307946729821448, 0.9730024763190815, -0.06603271991974888, 0.06603271991974888], "whMOVxAbqQMk.bottom" : [0.01524, 0.028531876322627103, 1.0, 0.0, -0.00774, 0.00774], "whMOVxAbqQMk.top" : [0.01524, -0.0939681236773729, 1.0, 0.0, -0.00774, 0.00774], "whMOVxAbqQMk.left" : [0.0075, -0.032718123677372896, 0.0, -1.0, -0.06125, 0.06125], "whMOVxAbqQMk.right" : [0.02298, -0.032718123677372896, 0.0, -1.0, -0.06125, 0.06125], "whMOVxAbqQMk.middle" : [0.01524, -0.032718123677372896], "XSwj11pP1k2S.0.offset" : [0.0, 0.0, 0.0, 0.0], "RNpxngWM4G2P.0.offset" : [0.0, 0.0, 0.0, 0.0] };
                    {
                    }
                    var SxVFNrCWbYGDKV_query;
                    SxVFNrCWbYGDKV_query=qCompressed(1.0,"&1c4$eJx9UMFygjAU/JnXYx1BiHgMEDS1oE041F6YQFLNVA2GOOrfF3Sml854fG/37dvdlziEj7OytxxxzwepO3Go9fYsnDbHVDiBvdz/j5S3VnFvAitG57TA71VK1qRISZFs+AyM1Vt9FPsOB8k4D7kAdXTa3YarWAD5G3gAJJ0TXsNOd87YxzKChBFc0lXRA6ZV9v6SytgHKrHHPW+EIHNxo9dBJju7WaJLhS7aqlXbfz8Nce5CEviSlMmiIkVJyw1X0P0o1+weBqjkTS90lSgsUBvS5vRWG+fMYfDMAhYyxKYsYoLVrGGSv3r+aALOtE/wAPbq2z0hhNB3s3MsSFAfPsMJGUh8CrrjTliXsSipHxlnkEVfdJF/Wjsm4+V1ViHTkquzZ6lYPbSE19Wg8AsB15Eo",id);
                    annotation { "Feature Name" : "panel holes" }
                    var sketch = newSketch(context, id + "FlpU4qVtZLrTCze_7", { "sketchPlane" : qUnion([SxVFNrCWbYGDKV_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "XSwj11pP1k2S.0", { "construction" : true, "index" : "1" });
                    skLineSegment(sketch, "RNpxngWM4G2P.0", { "construction" : true, "index" : "2" });
                    skLineSegment(sketch, "k6rvhYKhhZUV", { "construction" : true, "index" : "3" });
                    skLineSegment(sketch, "whMOVxAbqQMk.bottom", { "construction" : true, "index" : "4" });
                    skLineSegment(sketch, "whMOVxAbqQMk.top", { "construction" : true, "index" : "5" });
                    skLineSegment(sketch, "whMOVxAbqQMk.left", { "construction" : true, "index" : "6" });
                    skLineSegment(sketch, "whMOVxAbqQMk.right", { "construction" : true, "index" : "7" });
                    skPoint(sketch, "whMOVxAbqQMk.middle", { "construction" : true, "index" : "1" });
                    {
                        var hxhOTSQQquWcCZ_query;
                        hxhOTSQQquWcCZ_query=qCompressed(1.0,"&1c4$eJx9UMFygjAU/JnXYx1BiHgMEDS1oE041F6YQFLNVA2GOOrfF3Sml854fG/37dvdlziEj7OytxxxzwepO3Go9fYsnDbHVDiBvdz/j5S3VnFvAitG57TA71VK1qRISZFs+AyM1Vt9FPsOB8k4D7kAdXTa3YarWAD5G3gAJJ0TXsNOd87YxzKChBFc0lXRA6ZV9v6SytgHKrHHPW+EIHNxo9dBJju7WaJLhS7aqlXbfz8Nce5CEviSlMmiIkVJyw1X0P0o1+weBqjkTS90lSgsUBvS5vRWG+fMYfDMAhYyxKYsYoLVrGGSv3r+aALOtE/wAPbq2z0hhNB3s3MsSFAfPsMJGUh8CrrjTliXsSipHxlnkEVfdJF/Wjsm4+V1ViHTkquzZ6lYPbSE19Wg8AsB15Eo",id);
                        var FcQRqkPKvZCssy_query;
                        FcQRqkPKvZCssy_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FtBciP4FdsrYK6w_6wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$xd65N6p5IcqJtopR4R5R6R7S7$isStartFR8CbA1S11.9$F8ZIHMXrr0E0Kx9_6opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "XSwj11pP1k2S.distance", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "externalFirst" : qUnion([qCoEdge(hxhOTSQQquWcCZ_query, FcQRqkPKvZCssy_query)]), "localSecond" : "XSwj11pP1k2S.0", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : 0.5214175078287182, "labelDistance" : -0.004718025585412979 * meter, "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        var DBaNoBnCHcjIMC_query;
                        DBaNoBnCHcjIMC_query=qCompressed(1.0,"&1c4$eJx9UMFygjAU/JnXYx1BiHgMEDS1oE041F6YQFLNVA2GOOrfF3Sml854fG/37dvdlziEj7OytxxxzwepO3Go9fYsnDbHVDiBvdz/j5S3VnFvAitG57TA71VK1qRISZFs+AyM1Vt9FPsOB8k4D7kAdXTa3YarWAD5G3gAJJ0TXsNOd87YxzKChBFc0lXRA6ZV9v6SytgHKrHHPW+EIHNxo9dBJju7WaJLhS7aqlXbfz8Nce5CEviSlMmiIkVJyw1X0P0o1+weBqjkTS90lSgsUBvS5vRWG+fMYfDMAhYyxKYsYoLVrGGSv3r+aALOtE/wAPbq2z0hhNB3s3MsSFAfPsMJGUh8CrrjTliXsSipHxlnkEVfdJF/Wjsm4+V1ViHTkquzZ6lYPbSE19Wg8AsB15Eo",id);
                        var vjpDdckSGdUKYH_query;
                        vjpDdckSGdUKYH_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FtBciP4FdsrYK6w_6wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$xd65N6p5IcqJtopR4R5R6R7S7$isStartFR8CbA1S11.9$F8ZIHMXrr0E0Kx9_6opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "XSwj11pP1k2S.0.offset", { "constraintType" : ConstraintType.OFFSET, "index" : "1", "name" : "", "localOffset" : "XSwj11pP1k2S.0", "externalMaster" : qUnion([qCoEdge(DBaNoBnCHcjIMC_query, vjpDdckSGdUKYH_query)]), "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        var ShKfQMERhbhEWp_query;
                        ShKfQMERhbhEWp_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FtBciP4FdsrYK6w_6wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.5$xd65N6p5IcqJrightR4C6S4$FACER6R7R8CbA1S11.9$F8ZIHMXrr0E0Kx9_6opExtrudeRbSa$SWEPT_FACE",id);
                        var BPJiGOjfRNtnDg_query;
                        BPJiGOjfRNtnDg_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FtBciP4FdsrYK6w_6wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.5$xd65N6p5IcqJrightR4R5R6R7S7$isStartFR8CbA1S11.9$F8ZIHMXrr0E0Kx9_6opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "RNpxngWM4G2P.distance", { "constraintType" : ConstraintType.DISTANCE, "index" : "2", "name" : "", "externalFirst" : qUnion([qCoEdge(ShKfQMERhbhEWp_query, BPJiGOjfRNtnDg_query)]), "localSecond" : "RNpxngWM4G2P.0", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(7.5 * millimeter), 'expression' : "7.5 mm" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.LEFT, "labelRatio" : 0.5052490476355825, "labelDistance" : -0.056714534568786584 * meter, "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        var JjplAzRhEPHRwf_query;
                        JjplAzRhEPHRwf_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FtBciP4FdsrYK6w_6wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.5$xd65N6p5IcqJrightR4C6S4$FACER6R7R8CbA1S11.9$F8ZIHMXrr0E0Kx9_6opExtrudeRbSa$SWEPT_FACE",id);
                        var URcGsoJKywjrta_query;
                        URcGsoJKywjrta_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FtBciP4FdsrYK6w_6wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.5$xd65N6p5IcqJrightR4R5R6R7S7$isStartFR8CbA1S11.9$F8ZIHMXrr0E0Kx9_6opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "RNpxngWM4G2P.0.offset", { "constraintType" : ConstraintType.OFFSET, "index" : "2", "name" : "", "localOffset" : "RNpxngWM4G2P.0", "externalMaster" : qUnion([qCoEdge(JjplAzRhEPHRwf_query, URcGsoJKywjrta_query)]), "sketchToolType" : SketchToolType.OFFSET });
                    }
                    {
                        var dOoZbcuwFZFwUZ_query;
                        dOoZbcuwFZFwUZ_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FtBciP4FdsrYK6w_6wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6$xd65N6p5IcqJbottomC0M5R4R5R6R7R8RaRbRcRdS-12.4$leftR4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$F8ZIHMXrr0E0Kx9_6opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "k6rvhYKhhZUV.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "k6rvhYKhhZUV.start", "externalSecond" : qUnion([dOoZbcuwFZFwUZ_query]) });
                    }
                    {
                        var ujKkDKbnxfqVIq_query;
                        ujKkDKbnxfqVIq_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FtBciP4FdsrYK6w_6wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$xd65N6p5IcqJtopC0M5R4R5R6R7R8RaRbRcRdS-12.5$rightR4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$F8ZIHMXrr0E0Kx9_6opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "k6rvhYKhhZUV.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "k6rvhYKhhZUV.end", "externalSecond" : qUnion([ujKkDKbnxfqVIq_query]) });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localMidpoint" : "whMOVxAbqQMk.middle", "localEntity1" : "whMOVxAbqQMk.top.start", "localEntity2" : "whMOVxAbqQMk.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.mid2", { "constraintType" : ConstraintType.MIDPOINT, "index" : "2", "name" : "", "localMidpoint" : "whMOVxAbqQMk.middle", "localEntity1" : "whMOVxAbqQMk.top.end", "localEntity2" : "whMOVxAbqQMk.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "whMOVxAbqQMk.top", "localSecond" : "whMOVxAbqQMk.left" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "whMOVxAbqQMk.bottom", "localSecond" : "whMOVxAbqQMk.top" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "whMOVxAbqQMk.left", "localSecond" : "whMOVxAbqQMk.right" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "whMOVxAbqQMk.top" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "whMOVxAbqQMk.bottom.start", "localSecond" : "whMOVxAbqQMk.left.start" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "whMOVxAbqQMk.bottom.end", "localSecond" : "whMOVxAbqQMk.right.start" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "whMOVxAbqQMk.top.start", "localSecond" : "whMOVxAbqQMk.left.end" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "whMOVxAbqQMk.top.end", "localSecond" : "whMOVxAbqQMk.right.end" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.middle.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "3", "name" : "", "localEntity1" : "whMOVxAbqQMk.middle", "localEntity2" : "k6rvhYKhhZUV" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.cornerSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "name" : "", "localFirst" : "whMOVxAbqQMk.bottom.start", "localSecond" : "XSwj11pP1k2S.0" });
                    }
                    {
                        skConstraint(sketch, "whMOVxAbqQMk.cornerSnap1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "name" : "", "localFirst" : "whMOVxAbqQMk.bottom.start", "localSecond" : "RNpxngWM4G2P.0" });
                    }
                    skSetInitialGuess(sketch, initialGuessFlpU4qVtZLrTCze_7);
                    skSolve(sketch);
                }
            };
        try(features.FlpU4qVtZLrTCze_7(id));
        features.FlvTmFpSjPPqYUd_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var fMZShmnWUzKeUn_query;
                    fMZShmnWUzKeUn_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlpU4qVtZLrTCze_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6.5$whMOVxAbqQMkbottomstart",id);
                    var ofuTuGIoGwYMcx_query;
                    ofuTuGIoGwYMcx_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlpU4qVtZLrTCze_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6.3$whMOVxAbqQMkbottomend",id);
                    var eAIrUYLvdqNuki_query;
                    eAIrUYLvdqNuki_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlpU4qVtZLrTCze_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3.5$whMOVxAbqQMktopstart",id);
                    var NbOwAbRRmdqDCD_query;
                    NbOwAbRRmdqDCD_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlpU4qVtZLrTCze_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3.3$whMOVxAbqQMktopend",id);
                    var shatJMtvkuIEJo_query;
                    shatJMtvkuIEJo_query=qCompressed(1.0,"&1bb$eJx9UMluwjAQ/ZnpsYiExIVjFgMuJaF2pDa9RE7sglXAwTEC/r4OkXqpxHHmzbztKQ7h/SzNbR0yzwehOn6o1fbMrdLHlFseeWv/P1LcWsm8CeSULEgWvVUp3uAsxVlSshloo7bqyPddFCRjR8xBHq2yt/4r5oD/BhYATheY1bBTndVmWE4hoTgqSJ45QLfS3CWJiH0gIvKY540QzG3cqE0wF50pV+hSoYsyMm+d+qmPcycSwFa4SJYVzgpSlExC9yNtsxsMEMEaR3QVKMxQG5Lm9Fpra/Wh90wDGlJEX+iUclrThgr27PmjCVjdPsAD2Mtv++AgBNfNztIgQS58nKflcJTUQ7AZzKdfZLn+NGaMx6vrrEK6xVdrzkLS2jXJPvCmqPrHX+KZjm8=",id);
                    var VkIvZyAGNUphIp_query;
                    VkIvZyAGNUphIp_query=qCompressed(1.0,"&31a$eJydkstyozAQRX9Gs0wKEZ5LDMLR2AbSIqlxNhRGcqwa22AhJ/Z8/QiT19RsUtlJfdX3XHX1j4mL7o5CnRcuwzbisq93K/l0rLVs90mt6wgv7P+V8twJFqAyL/J5Pl2ao9hrqaXoIyeyY8u4rRAXSj4Lnqp2ZyoeWIMXYIZvUA50SrNoXiWkIFlCsnjJQtQq+ST39baP8MWiHl3PA21SI/J+YQ4iyZQYxkb2ulXn1zwxkKikeWaEthPqEpXyiY0ojwwXX3so1ZNGFk7Ke7WceS+V9yKVyDtDPwxjuBhxxGakjG8rkpW0XDKB+t9CN5sxAOWsMUYn7rmZ17m0OfxctVq3O/AhgBBq5iPZM10rncIqFiM5RGnwSG8Xv5SyiDU7hZXXduSk1ZELuGSPimr41JvLR6uP0m137xwe9ONclfEfUfly1ym516bRR3RRAM3K5AqPkwfn87TBBW8c54cxcBCwBmyxK+xe3yDddu8i9kxowIF5gcNPLbgZKjz5JsRBW7HWX6WAHXwP4yKzQpuvc/Aa/Dg065RGMflX+wsaG/SR",id);
                    annotation { "Feature Name" : "#featureName" }
                    hole(context, id + "FlvTmFpSjPPqYUd_7", { "isV2" : true, "holeVersion" : HoleVersion.V3, "initEntities" : qUnion([]), "featureName" : "Ø #holeDiameterV3 ↧ #holeDepthV3", "threadStandard" : ThreadStandard.UNSET, "hasClearance" : false, "unitsSystem" : UnitsSystem.METRIC, "styleV2" : HoleStyle.SIMPLE, "style" : HoleStyle.SIMPLE, "locations" : qUnion([fMZShmnWUzKeUn_query, ofuTuGIoGwYMcx_query, eAIrUYLvdqNuki_query, NbOwAbRRmdqDCD_query]), "scope" : qUnion([shatJMtvkuIEJo_query]), "ansiHoleTableEx" : lookupTablePath({ "size" : "1/4 (0.25)", "holeType" : "Drilled" }), "ansiHoleTable" : lookupTablePath({ "size" : "1/4 (0.25)", "holeType" : "Drilled" }), "isoHoleTableEx" : lookupTablePath({ "fit" : "Normal", "size" : "M3.5", "holeType" : "Clearance" }), "isoHoleTable" : lookupTablePath({ "fit" : "Close", "size" : "M3.5", "holeType" : "Clearance" }), "showThreadClassV2" : false, "ansiThreadClassV2" : lookupTablePath({ "class" : "2B" }), "isoThreadClassV2" : lookupTablePath({ "class" : "6H" }), "showTappedDepth" : false, "holeDiameterV3" : { 'value' : try(3.2 * millimeter), 'expression' : "3.2 mm" }.value, "tapDrillDiameterV3" : { 'value' : try(3.75 * millimeter), 'expression' : "3.75 mm" }.value, "holeDiameterV2" : 3.2 * millimeter, "holeDiameterV2Precision" : PrecisionType.DEFAULT, "holeDiameterV2ToleranceType" : ToleranceTypeExtended.NONE, "holeDiameterV2ToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2ToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2ToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterV2ToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2ToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterV2FitToleranceTable" : lookupTablePath({ "fit" : "User defined", "standard" : "ISO", "shaftClass" : "None", "holeClass" : "A9" }), "holeDiameterV2holeClassToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2holeClassToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tapDrillDiameterV2" : { 'value' : try(3.75 * millimeter), 'expression' : "3.75 mm" }.value, "tapDrillDiameterV2Precision" : PrecisionType.DEFAULT, "tapDrillDiameterV2ToleranceType" : ToleranceType.NONE, "tapDrillDiameterV2ToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "startStyle" : HoleStartStyle.PLANE, "startBoundEntity" : qUnion([VkIvZyAGNUphIp_query]), "endStyleV2" : HoleEndStyleV2.BLIND, "endStyle" : HoleEndStyle.BLIND, "oppositeDirection" : false, "endBoundEntity" : qUnion([]), "offset" : false, "offsetDistance" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeOffsetDirection" : false, "standardTappedOrClearance" : lookupTablePath({ "standard" : "Custom" }), "standardBlindInLast" : lookupTablePath({ "standard" : "Custom" }), "showThreadClass" : false, "ansiThreadClass" : lookupTablePath({ "class" : "2B" }), "isoThreadClass" : lookupTablePath({ "class" : "6H" }), "holeDiameter" : 3.2 * millimeter, "holeDiameterPrecision" : PrecisionType.DEFAULT, "holeDiameterToleranceType" : ToleranceTypeExtended.NONE, "holeDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterFitToleranceTable" : lookupTablePath({ "fit" : "User defined", "standard" : "ISO", "shaftClass" : "None", "holeClass" : "A9" }), "holeDiameterholeClassToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterholeClassToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDiameterV3" : { 'value' : try(7.375 * millimeter), 'expression' : "7.375 mm" }.value, "cBoreDepthV3" : { 'value' : try(3.5 * millimeter), 'expression' : "3.5 mm" }.value, "cBoreDiameter" : { 'value' : try(7.375 * millimeter), 'expression' : "7.375 mm" }.value, "cBoreDiameterPrecision" : PrecisionType.DEFAULT, "cBoreDiameterToleranceType" : ToleranceType.NONE, "cBoreDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDepth" : { 'value' : try(3.5 * millimeter), 'expression' : "3.5 mm" }.value, "cBoreDepthPrecision" : PrecisionType.DEFAULT, "cBoreDepthToleranceType" : ToleranceType.NONE, "cBoreDepthToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDepthToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDepthToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDepthToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDepthToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cSinkDiameterV3" : { 'value' : try(7.84 * millimeter), 'expression' : "7.84 mm" }.value, "cSinkAngleV3" : { 'value' : try(90 * degree), 'expression' : "90 degree" }.value, "cSinkDiameter" : { 'value' : try(7.84 * millimeter), 'expression' : "7.84 mm" }.value, "cSinkDiameterPrecision" : PrecisionType.DEFAULT, "cSinkDiameterToleranceType" : ToleranceType.NONE, "cSinkDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cSinkDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cSinkDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cSinkDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cSinkDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cSinkAngle" : { 'value' : try(90 * degree), 'expression' : "90 degree" }.value, "cSinkAnglePrecision" : PrecisionType.DEFAULT, "cSinkAngleToleranceType" : ToleranceType.NONE, "cSinkAngleToleranceBoundSymmetrical" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "cSinkAngleToleranceBoundDeviationUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "cSinkAngleToleranceBoundDeviationLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "cSinkAngleToleranceBoundLimitsUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "cSinkAngleToleranceBoundLimitsLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "tapDrillDiameter" : { 'value' : try(3.75 * millimeter), 'expression' : "3.75 mm" }.value, "tapDrillDiameterPrecision" : PrecisionType.DEFAULT, "tapDrillDiameterToleranceType" : ToleranceType.NONE, "tapDrillDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tapDrillDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "majorDiameter" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "isMultiple" : false, "holeDepthMultiple" : "Multiple", "holeDepthMultiplePrecision" : PrecisionType.DEFAULT, "holeDepthMultipleToleranceType" : ToleranceType.NONE, "holeDepthMultipleToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthMultipleToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthMultipleToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthMultipleToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthMultipleToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthComputedV3" : { 'value' : try(12 * millimeter), 'expression' : "12 mm" }.value, "holeDepthComputed" : { 'value' : try(12 * millimeter), 'expression' : "12 mm" }.value, "holeDepthComputedPrecision" : PrecisionType.DEFAULT, "holeDepthComputedToleranceType" : ToleranceType.NONE, "holeDepthComputedToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthComputedToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthComputedToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthComputedToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthComputedToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthV3" : { 'value' : try(3.5 * millimeter), 'expression' : "3.5 mm" }.value, "holeDepth" : { 'value' : try(3.5 * millimeter), 'expression' : "3.5 mm" }.value, "holeDepthPrecision" : PrecisionType.DEFAULT, "holeDepthToleranceType" : ToleranceType.NONE, "holeDepthToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tipAngleStyle" : TipAngleStyle.DEGREE118, "tipAngleV3" : { 'value' : try(118 * degree), 'expression' : "118 deg" }.value, "tipAngle" : { 'value' : try(118 * degree), 'expression' : "118 deg" }.value, "tipAnglePrecision" : PrecisionType.DEFAULT, "tipAngleToleranceType" : ToleranceType.NONE, "tipAngleToleranceBoundSymmetrical" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "tipAngleToleranceBoundDeviationUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "tipAngleToleranceBoundDeviationLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "tipAngleToleranceBoundLimitsUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "tipAngleToleranceBoundLimitsLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "isTappedThrough" : true, "tappedDepthV3" : { 'value' : try(6.9 * millimeter), 'expression' : "6.9 mm" }.value, "tappedDepth" : { 'value' : try(6.9 * millimeter), 'expression' : "6.9 mm" }.value, "tappedDepthPrecision" : PrecisionType.DEFAULT, "tappedDepthToleranceType" : ToleranceType.NONE, "tappedDepthToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tappedDepthToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tappedDepthToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tappedDepthToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tappedDepthToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tappedAngle" : { 'value' : try(1.789911 * degree), 'expression' : "1.789911 deg" }.value, "tapClearance" : { 'value' : try(3), 'expression' : "3" }.value, "toleranceMatching" : { 'value' : try({ "cBoreDepth" : "cBoreDepthV3", "cBoreDiameter" : "cBoreDiameterV3", "cSinkAngle" : "cSinkAngleV3", "cSinkDiameter" : "cSinkDiameterV3", "holeDepth" : "holeDepthV3", "holeDepthComputed" : "holeDepthComputedV3", "holeDiameter" : "holeDiameterV2", "holeDiameterV2" : "holeDiameterV3", "tapDrillDiameter" : "tapDrillDiameterV2", "tapDrillDiameterV2" : "tapDrillDiameterV3", "tappedDepth" : "tappedDepthV3", "tipAngle" : "tipAngleV3" }), 'expression' : "{\"cBoreDepth\" : \"cBoreDepthV3\", \"cBoreDiameter\" : \"cBoreDiameterV3\", \"cSinkAngle\" : \"cSinkAngleV3\", \"cSinkDiameter\" : \"cSinkDiameterV3\", \"holeDepth\" : \"holeDepthV3\", \"holeDepthComputed\" : \"holeDepthComputedV3\", \"holeDiameter\" : \"holeDiameterV2\", \"holeDiameterV2\" : \"holeDiameterV3\", \"tapDrillDiameter\" : \"tapDrillDiameterV2\", \"tapDrillDiameterV2\" : \"tapDrillDiameterV3\", \"tappedDepth\" : \"tappedDepthV3\", \"tipAngle\" : \"tipAngleV3\"}" }.value, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FlvTmFpSjPPqYUd_7(id));
        features.Fga1cnVS33C7GRM_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFga1cnVS33C7GRM_7 = { "gVXL9PehLZhy.bottom" : [0.026480000000000004, -0.007651202611241087, 1.0, 0.0, -0.002850000000000002, 0.0028499999999999984], "gVXL9PehLZhy.top" : [0.026480000000000004, -0.0019512026112410864, 1.0, 0.0, -0.002850000000000002, 0.0028499999999999984], "gVXL9PehLZhy.left" : [0.02363, -0.0046702694579058126, 6.123233995736766E-17, 1.0, -0.002980933153335274, 0.002719066846664726], "gVXL9PehLZhy.right" : [0.029330000000000002, -0.0046702694579058126, 6.123233995736766E-17, 1.0, -0.002980933153335274, 0.002719066846664726], "gVXL9PehLZhy.middle" : [0.026480000000000004, -0.0048012026112410865], "zRnQUt6kQxkH.bottom" : [0.03129696187200346, -0.05265120261124109, 1.0, 0.0, -0.007666961872003459, -0.0019669618720034587], "zRnQUt6kQxkH.top" : [0.026480000000000004, -0.04695120261124109, 1.0, 0.0, -0.002850000000000002, 0.0028499999999999984], "zRnQUt6kQxkH.left" : [0.02363, -0.046408264978068554, 6.123233995736767E-17, 1.0, -0.006242937633172532, -5.429376331725355E-4], "zRnQUt6kQxkH.right" : [0.029330000000000002, -0.05319414024441362, 6.123233995736767E-17, 1.0, 5.429376331725355E-4, 0.006242937633172532], "zRnQUt6kQxkH.middle" : [0.026480000000000004, -0.04980120261124109], "UbkXdxoPAqAn.bottom" : [0.031131358557391083, -0.0976512026112411, 1.0, 0.0, -0.007501358557391077, -0.0018013585573910806], "UbkXdxoPAqAn.top" : [0.026480000000000004, -0.09195120261124111, 1.0, 0.0, -0.0028499999999999984, 0.0028500000000000053], "UbkXdxoPAqAn.left" : [0.023630000000000005, -0.09187505745406985, 6.123233995736766E-17, 1.0, -0.0057761451571712585, -7.61451571712618E-5], "UbkXdxoPAqAn.right" : [0.029330000000000002, -0.09772734776841237, 6.123233995736766E-17, 1.0, 7.61451571712618E-5, 0.0057761451571712585], "UbkXdxoPAqAn.middle" : [0.026480000000000004, -0.09480120261124111] };
                    {
                    }
                    var hoKlMoqgUcROxr_query;
                    hoKlMoqgUcROxr_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$eW0jhRAeEetYR4C6S4$FACER6R7R8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbSa$SWEPT_FACE",id);
                    annotation { "Feature Name" : "Sketch 4" }
                    var sketch = newSketch(context, id + "Fga1cnVS33C7GRM_7", { "sketchPlane" : qUnion([hoKlMoqgUcROxr_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "gVXL9PehLZhy.bottom", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "gVXL9PehLZhy.top", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "gVXL9PehLZhy.left", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "gVXL9PehLZhy.right", { "construction" : false, "index" : "4" });
                    skPoint(sketch, "gVXL9PehLZhy.middle", { "construction" : true, "index" : "1" });
                    skLineSegment(sketch, "zRnQUt6kQxkH.bottom", { "construction" : false, "index" : "5" });
                    skLineSegment(sketch, "zRnQUt6kQxkH.top", { "construction" : false, "index" : "6" });
                    skLineSegment(sketch, "zRnQUt6kQxkH.left", { "construction" : false, "index" : "7" });
                    skLineSegment(sketch, "zRnQUt6kQxkH.right", { "construction" : false, "index" : "8" });
                    skPoint(sketch, "zRnQUt6kQxkH.middle", { "construction" : true, "index" : "2" });
                    skLineSegment(sketch, "UbkXdxoPAqAn.bottom", { "construction" : false, "index" : "9" });
                    skLineSegment(sketch, "UbkXdxoPAqAn.top", { "construction" : false, "index" : "10" });
                    skLineSegment(sketch, "UbkXdxoPAqAn.left", { "construction" : false, "index" : "11" });
                    skLineSegment(sketch, "UbkXdxoPAqAn.right", { "construction" : false, "index" : "12" });
                    skPoint(sketch, "UbkXdxoPAqAn.middle", { "construction" : true, "index" : "3" });
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localMidpoint" : "gVXL9PehLZhy.middle", "localEntity1" : "gVXL9PehLZhy.top.start", "localEntity2" : "gVXL9PehLZhy.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.mid2", { "constraintType" : ConstraintType.MIDPOINT, "index" : "2", "name" : "", "localMidpoint" : "gVXL9PehLZhy.middle", "localEntity1" : "gVXL9PehLZhy.top.end", "localEntity2" : "gVXL9PehLZhy.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "gVXL9PehLZhy.top", "localSecond" : "gVXL9PehLZhy.left" });
                    }
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "gVXL9PehLZhy.bottom", "localSecond" : "gVXL9PehLZhy.top" });
                    }
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "gVXL9PehLZhy.left", "localSecond" : "gVXL9PehLZhy.right" });
                    }
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "gVXL9PehLZhy.top" });
                    }
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "gVXL9PehLZhy.bottom.start", "localSecond" : "gVXL9PehLZhy.left.start" });
                    }
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "gVXL9PehLZhy.bottom.end", "localSecond" : "gVXL9PehLZhy.right.start" });
                    }
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "gVXL9PehLZhy.top.start", "localSecond" : "gVXL9PehLZhy.left.end" });
                    }
                    {
                        skConstraint(sketch, "gVXL9PehLZhy.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "gVXL9PehLZhy.top.end", "localSecond" : "gVXL9PehLZhy.right.end" });
                    }
                    {
                        var ryGhqWxjrvYPUt_query;
                        ryGhqWxjrvYPUt_query=qCompressed(1.0,"&268$eJxlUclymzAYfhn1mAxiMeHIIhzcIrsSTUovjIwUoxADESIOffoKM9NO0pv+5dt+fYk88H0Sas49egRcKPkmeKr6c2jHlulBG3A5svNRniamZd8lTLMQ5vb/k2IeBIUO2JNsm+HwW5WgA8IJwnFJA9AreZIdexlDeCVmQHRa6nlBRQygvwV1AUq2yLhp5Kh7tTbvQExQWGR7bAb9INRVMuORDTIeQgrh7Qak+FWNb9uHbW79ao9J5VykEvvBqL8uEa9EHNCvqIjvK4SLrCipAGMrdN2sBjJOayAereeGhAIJXRIv9o2jNIwR8ckdCeJ6VQtAOp1GBu+DTSv93c6vnH5A71pNXJDaxKOP6FBUC9Dk3RBrSU3gcjpiE4e46x2IRzYfiW8ESOvnXeT778Hvize1eeWSmnAijDVLyFr54+mhfPINFLqfsNAcgWbsoprAgTxvfsxXMPy3bEhkN2rW1QKzs/kwAD+EwnMLi3PxFI7OzwZXXj8cmNZCdSaUC+L9ofxk+ca2bn2DPPb9i2BdP0Trw+wHIMMFIhTFxR8XqsNd",id);
                        skConstraint(sketch, "gVXL9PehLZhy.middle.positionSnap0", { "constraintType" : ConstraintType.CONCENTRIC, "index" : "1", "name" : "", "localFirst" : "gVXL9PehLZhy.middle", "externalSecond" : qUnion([ryGhqWxjrvYPUt_query]) });
                    }
                    {
                        skConstraint(sketch, "u9rX9pdhE9eH", { "constraintType" : ConstraintType.LENGTH, "index" : "1", "name" : "", "localFirst" : "gVXL9PehLZhy.bottom", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('RailBlockNutWidth') - .1 * millimeter), 'expression' : "#RailBlockNutWidth-.1mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : -2.0188950883261043, "labelDistance" : 0.003629078123680336 * meter });
                    }
                    {
                        skConstraint(sketch, "XvSKoqiXaojx", { "constraintType" : ConstraintType.EQUAL, "index" : "1", "name" : "", "localFirst" : "gVXL9PehLZhy.bottom", "localSecond" : "gVXL9PehLZhy.left" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "3", "name" : "", "localMidpoint" : "zRnQUt6kQxkH.middle", "localEntity1" : "zRnQUt6kQxkH.top.start", "localEntity2" : "zRnQUt6kQxkH.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.mid2", { "constraintType" : ConstraintType.MIDPOINT, "index" : "4", "name" : "", "localMidpoint" : "zRnQUt6kQxkH.middle", "localEntity1" : "zRnQUt6kQxkH.top.end", "localEntity2" : "zRnQUt6kQxkH.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "2", "name" : "", "localFirst" : "zRnQUt6kQxkH.top", "localSecond" : "zRnQUt6kQxkH.left" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "3", "name" : "", "localFirst" : "zRnQUt6kQxkH.bottom", "localSecond" : "zRnQUt6kQxkH.top" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "4", "name" : "", "localFirst" : "zRnQUt6kQxkH.left", "localSecond" : "zRnQUt6kQxkH.right" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "2", "name" : "", "localFirst" : "zRnQUt6kQxkH.top" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "zRnQUt6kQxkH.bottom.start", "localSecond" : "zRnQUt6kQxkH.left.start" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "zRnQUt6kQxkH.bottom.end", "localSecond" : "zRnQUt6kQxkH.right.start" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "name" : "", "localFirst" : "zRnQUt6kQxkH.top.start", "localSecond" : "zRnQUt6kQxkH.left.end" });
                    }
                    {
                        skConstraint(sketch, "zRnQUt6kQxkH.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "name" : "", "localFirst" : "zRnQUt6kQxkH.top.end", "localSecond" : "zRnQUt6kQxkH.right.end" });
                    }
                    {
                        var BmxzUSsWZDkUQG_query;
                        BmxzUSsWZDkUQG_query=qCompressed(1.0,"&227$eJxlkF1TozAUhv9M9nKdBkojlwFCpQp1k6zavWFSEkvENhjAyv76DWVmZ9S75Jx5P57zIwrAr0HZMQ/YHkhl9buSqTVH7MULN4MekLoTx70+DKLX5pSIXmCYe983fGwVgz7Y0mydFfiuTMg9KRJSxDsWAmP1QZ/Ea4fhxVgAdep1P06qSADy/8OWgCRr4trUuuuNnYfXIKYE82xbuIVplb1EZjLyQCYxZBBerUBavNnuff2wzhd/mn1S+mdt1bZ16W8T4sVIAnZLeHxTkoJnfMcU6BrVV/VcIJOsAupx8VJTrIjqdzSIkWuU4phQRK9pGFdzWgjS4dAJeBOuGo02G1T6piUfvR2kopXDY4/knpeTcOKlcDoa9ahPl/MFaEBXny1/KpBWL5sIoY/w7zkYmrxc0opKqlyphdKVRd3hYfeMnBQuv2ihw2eZONs69KHM69/jRQzR9xw0lS/GBvIjf8ad/1QXZbA35lWJk2mj+eEYQpAVnFBGYv4PLoavow==",id);
                        skConstraint(sketch, "zRnQUt6kQxkH.middle.positionSnap0", { "constraintType" : ConstraintType.CONCENTRIC, "index" : "2", "name" : "", "localFirst" : "zRnQUt6kQxkH.middle", "externalSecond" : qUnion([BmxzUSsWZDkUQG_query]) });
                    }
                    {
                        skConstraint(sketch, "56IHpyMVqlOS", { "constraintType" : ConstraintType.EQUAL, "index" : "2", "name" : "", "localFirst" : "zRnQUt6kQxkH.top", "localSecond" : "gVXL9PehLZhy.bottom" });
                    }
                    {
                        skConstraint(sketch, "mfBnp7gBbtHb", { "constraintType" : ConstraintType.EQUAL, "index" : "3", "name" : "", "localFirst" : "zRnQUt6kQxkH.left", "localSecond" : "gVXL9PehLZhy.bottom" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "5", "name" : "", "localMidpoint" : "UbkXdxoPAqAn.middle", "localEntity1" : "UbkXdxoPAqAn.top.start", "localEntity2" : "UbkXdxoPAqAn.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.mid2", { "constraintType" : ConstraintType.MIDPOINT, "index" : "6", "name" : "", "localMidpoint" : "UbkXdxoPAqAn.middle", "localEntity1" : "UbkXdxoPAqAn.top.end", "localEntity2" : "UbkXdxoPAqAn.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "3", "name" : "", "localFirst" : "UbkXdxoPAqAn.top", "localSecond" : "UbkXdxoPAqAn.left" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "5", "name" : "", "localFirst" : "UbkXdxoPAqAn.bottom", "localSecond" : "UbkXdxoPAqAn.top" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "6", "name" : "", "localFirst" : "UbkXdxoPAqAn.left", "localSecond" : "UbkXdxoPAqAn.right" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "3", "name" : "", "localFirst" : "UbkXdxoPAqAn.top" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "9", "name" : "", "localFirst" : "UbkXdxoPAqAn.bottom.start", "localSecond" : "UbkXdxoPAqAn.left.start" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "10", "name" : "", "localFirst" : "UbkXdxoPAqAn.bottom.end", "localSecond" : "UbkXdxoPAqAn.right.start" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "11", "name" : "", "localFirst" : "UbkXdxoPAqAn.top.start", "localSecond" : "UbkXdxoPAqAn.left.end" });
                    }
                    {
                        skConstraint(sketch, "UbkXdxoPAqAn.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "12", "name" : "", "localFirst" : "UbkXdxoPAqAn.top.end", "localSecond" : "UbkXdxoPAqAn.right.end" });
                    }
                    {
                        var iwVCGZODPSstuI_query;
                        iwVCGZODPSstuI_query=qCompressed(1.0,"&269$eJxlUMtymzAU/Rl16QziYcKSh3Bwi+xKalK6YWRQjEIMRMhx6NdXmJlmkuyke+95fos88PMs1JR79ABqoeSrqFPVn0I7tswM2qCWIz8d5PHMtey7hGsewtz+umHTICh0wI5kmwyHP8oE7RFOEI4LGoBeyaPs+PMYwisxB6LTUk8zKuIA/f9QF6Bkg4ybRo66V8vwFsQEhSzbYbPoB6Guklkd2SCrQ0ghvFmDFL+o8XVzv8mtP+0hKZ2LVGI3GPWXOeKVqAb0O2LxXYkwy1hBBRhboatmMZDVtALiwXpqSCiQ0AXxYt84SsMYEZ/ckiCuFrUApOfjyOFdsG6lv936pdMP6E2rcy1IZeLRB7Rn5Qw0edfEmlMTOFdHbOIQd+mBeGT9kXglQFo9bSPffwv+Xrxzm5cuqUhNhLFmCVkpfzzeF4++gUL3ExaaEmjGL6oJHFjnza/pCobvx4ZEdqPmXSUwPwlqgxX8kApPLWQn9hiOzu8Gl14/7LnWQnUmlQvi3b745HllWze+QR76/lnwrh+i5WHuA5BhhghFMfsHzhjDiw==",id);
                        skConstraint(sketch, "UbkXdxoPAqAn.middle.positionSnap0", { "constraintType" : ConstraintType.CONCENTRIC, "index" : "3", "name" : "", "localFirst" : "UbkXdxoPAqAn.middle", "externalSecond" : qUnion([iwVCGZODPSstuI_query]) });
                    }
                    {
                        skConstraint(sketch, "UDg30DB2DnBV.0", { "constraintType" : ConstraintType.EQUAL, "index" : "4", "name" : "", "localFirst" : "UbkXdxoPAqAn.left", "localSecond" : "UbkXdxoPAqAn.top" });
                    }
                    {
                        skConstraint(sketch, "UDg30DB2DnBV.1", { "constraintType" : ConstraintType.EQUAL, "index" : "5", "name" : "", "localFirst" : "UbkXdxoPAqAn.left", "localSecond" : "zRnQUt6kQxkH.bottom" });
                    }
                    skSetInitialGuess(sketch, initialGuessFga1cnVS33C7GRM_7);
                    skSolve(sketch);
                }
            };
        try(features.Fga1cnVS33C7GRM_7(id));
        features.FsCk1Kzgjt3IDSm_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var sDTMUUZNZqsYuq_query;
                    sDTMUUZNZqsYuq_query=qCompressed(1.0,"&3f0$eJyNkltzojAUx79M9lGHcDHlESFaXLlswtraFyZCKqkKNMS27KffeFmntp2dvmSSnPP7n+uPsQN+7bnsI4dCE5SiY7uVWO+ZEk0dMMU8GJmfLVnfcnoDsiRN5sl0qa+8VkIJ3nmOZ/qGVluBkkvxwsuJbHbHH3Zy6g/wmAF8eVAb4GCKNVKJTjWyP8v7BHtZmMTa0LRcHiOH5dgEYelBCuFwBCZrBot6QS3LR1MS5ehVSJ601AXPh6qOQiWgP3Hm3+Y4zsJsSTnoNlwV1SmBsKSFFlov7uduyqv5Q9WvGqWaHXHIiCByQ1y/0OEG5RABsWulqBUpKAJhlJIwzgJ4KpjYx/MCkRUpSEk4HUBraAHVtO9s0NRGaAWD78A22PJH9ZkmkH2DdoAU6+pL3LnC7fPLOIyc6P5aICHhNIy9eR7gFMcBjv2l7myjBUXNtp0Hr+Me+6THMuBgEj/L7mW6mEbGw2YV5NY5owLwO+OpIh7HXC2J4yM9/Inn42sFF0z2647BW3e0EWg2Q7nVtPhNyX3JdfMZoHc4zfIDqFMYnSs4Z05Mm5jO/5IrnmZjhN7cP6/OfhPl9iU5g4tCom69WD4ijZrlB9bUG0dD9ior14JlVP3uj7BlXJy1iKg7xeqCx2zHKQTwqqy438Bslz16nXVfxbnTtClTistal2UDP0mXH/fOMoZIk6um2XJWN+34dNH+LtD7hwnFfvbldryr4N/vX+gjMoo=",id);
                    var jluOBEHrVfHZvW_query;
                    jluOBEHrVfHZvW_query=qCompressed(1.0,"&3af$eJyNkl1zojAUhv9M9lLHgJhyiRARt6Am1K57wwSIkqJAIVbpr9/4sY6unZ3eZJKcPO95zzn5MTTAfMfr1jco1EAqGraNxXrHpCgLh0lmQV97jIRtxekTCKez6fPUXaotL6SQgjeWYWl2T6nFIOW1+ODpqC63pxt2ftQe4SED+HqgfYAdFyskE40s6/YibxNshd40UIGy4vUps5cONeClFqQQdgdgtGYwKRZU123kEj9Ce1HzaUVN8H6s6iSUAvoTh/Y4wkHohUvKQZNzmWRnA15KEyX0SYr5ixzk80M+jkspyy0xyIAg8kRMO1HpOmkXAbGtalFIklAEPH9GvCB04Llg0j+tV4jEJCEp4bQD9a4OZFndxKCmglB3Ot+B+2DDV/KRJpB9gzZALdbZl7hxh/cvp95x5ET1VwdT4rleYD1HDp7hwMGBvVSdLZWgKNimseB93lOf1Fg6HIyC97r5cBeu3/udx06kXxwlgL/23jJicczlkhg2UsMfWTa+VzDBaLduGBybg1ygyQRFelnhg6x3KVfNZ4C+4lkYHcFbz0TrE834n63kbTJE6GB+7o1d7kf9q60eF0mNmvViuUIK1dJ/WE39NeqxfZ2ZOkz97KU9wXrvMQ862g/aHIbbcGU1+q8siIy4LDecFWU1PG9UFSZQ3wcTiu3wy+He2Ph7+wflZB7N",id);
                    var IEVtVNHwbGhbeA_query;
                    IEVtVNHwbGhbeA_query=qCompressed(1.0,"&3f1$eJyNktlS2zAUhl9GvUzG8hLjS8dWgileKpklvfHIlohFiGVkBUifvsrSDAGmw41G0jnff9YfUw/82nC1TT0CbcDEQNe1WG6oFrKLqaYhTO3PlnLbc3IByrzIr/P5wlx5p4UWfAi90I4so1YDxpV44Wym5Hr/Qw9O2x08pQCdHsQFKJ4jg7Ri0FJtj/IRRmGZ5JkxyJ6rfeSETW2QsBASCMcTMFtS2HS3xHEif47Tyn8Viuc9CcDzrqq9EAPkJyqjywplZVIuCAfDiuumPSSQMNIYoZt6dc/eZBE+h10ttZZr7OEJ9vEFDqLGhBuxsQ/Eulei07ghPkjSAidZGcNDwdjdnycI17jBDHMygs7YAVr272zQNkboxKPvwC544g/6M40h/QbtASWW7Ze4d4a7x5e1Gzk2/XVAjpN5koXXVYwKlMUoixams9IIio4+DSE8j7vvkxnLiINZ9qyGl/ntPLV+r+q4co4ZNYDfWY8tDjnieoG9yDfDn4UROlcIwGyzHCi8DCYr4V9d+ZUje/Sm1YZx03wKyB0qymoHmhQmxwqOmWPbxbb3v+Sax6up778Ff169zSqt3FNyFheN8ofl7eLBN6jNPrC22TiS0FfVBg5kaXuz3cOOdXI2IqIbNO0antE1JzYYwbO6su0KluvyIRyc+zarPNkXVGuuOlOXC6K8WHxcPMca+4aspXzitJP99HAx/gEwC4gwQVH55Xq8K+Hf71+tCDLw",id);
                    var IxTFqyISzmDZmN_query;
                    IxTFqyISzmDZmN_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    annotation { "Feature Name" : "Extrude 7" }
                    extrude(context, id + "FsCk1Kzgjt3IDSm_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.REMOVE, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([sDTMUUZNZqsYuq_query, jluOBEHrVfHZvW_query, IEVtVNHwbGhbeA_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(lookup('RailBlockNutDepth')), 'expression' : "#RailBlockNutDepth" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([IxTFqyISzmDZmN_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FsCk1Kzgjt3IDSm_7(id));
        features.F8wggogTepNUM5x_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessF8wggogTepNUM5x_7 = { "5wmPxsLl5s7z.bottom" : [0.12811127956685656, 0.09659736546277999, -1.0, -1.2246467991473532E-16, -0.0028187204331434346, 0.0028812795668565483], "5wmPxsLl5s7z.top" : [0.12808, 0.10229736546277998, -1.0, -1.2246467991473532E-16, -0.0028499999999999914, 0.0028499999999999914], "5wmPxsLl5s7z.left" : [0.13093, 0.09944736546277999, 6.123233995736765E-17, 1.0, -0.0028500000000000053, 0.0028499999999999914], "5wmPxsLl5s7z.right" : [0.12523, 0.09944736546277999, 6.123233995736765E-17, 1.0, -0.0028500000000000053, 0.0028499999999999914], "5wmPxsLl5s7z.middle" : [0.12808, 0.09944736546277999], "df9M2iMwZqHF.0.0.1" : [0.12523, 0.07644736546277998, 6.123233995736765E-17, 1.0, -0.0028500000000000053, 0.0028499999999999914], "df9M2iMwZqHF.1.0.1" : [0.12811127956685656, 0.07359736546277998, -1.0, -1.2246467991473532E-16, -0.0028187204331434346, 0.0028812795668565483], "df9M2iMwZqHF.2.0.1" : [0.13093, 0.07644736546277998, 6.123233995736765E-17, 1.0, -0.0028500000000000053, 0.0028499999999999914], "df9M2iMwZqHF.3.0.1" : [0.12808, 0.07929736546277998, -1.0, -1.2246467991473532E-16, -0.0028499999999999914, 0.0028499999999999914], "df9M2iMwZqHF.0.0.2" : [0.12523, 0.05344736546277998, 6.123233995736765E-17, 1.0, -0.0028500000000000053, 0.0028499999999999914], "df9M2iMwZqHF.1.0.2" : [0.12811127956685656, 0.05059736546277997, -1.0, -1.2246467991473532E-16, -0.0028187204331434346, 0.0028812795668565483], "df9M2iMwZqHF.2.0.2" : [0.13093, 0.05344736546277998, 6.123233995736765E-17, 1.0, -0.0028500000000000053, 0.0028499999999999914], "df9M2iMwZqHF.3.0.2" : [0.12808, 0.05629736546277997, -1.0, -1.2246467991473532E-16, -0.0028499999999999914, 0.0028499999999999914], "df9M2iMwZqHF.direction1" : [0.13773000000000002, 0.09659736546277999, 1.0, 0.0, -0.012500000000000011, 0.012499999999999983], "df9M2iMwZqHF.direction2" : [0.12523, 0.08509736546277999, 0.0, -1.0, -0.011499999999999996, 0.01150000000000001] };
                    {
                    }
                    var RLTuQgbbJqfJtj_query;
                    RLTuQgbbJqfJtj_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$dkjp0VnBosyxR4C6S4$FACER6R7R8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbSa$SWEPT_FACE",id);
                    annotation { "Feature Name" : "Rear Bolt Capture" }
                    var sketch = newSketch(context, id + "F8wggogTepNUM5x_7", { "sketchPlane" : qUnion([RLTuQgbbJqfJtj_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "5wmPxsLl5s7z.bottom", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "5wmPxsLl5s7z.top", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "5wmPxsLl5s7z.left", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "5wmPxsLl5s7z.right", { "construction" : false, "index" : "4" });
                    skPoint(sketch, "5wmPxsLl5s7z.middle", { "construction" : true, "index" : "1" });
                    skLineSegment(sketch, "df9M2iMwZqHF.0.0.1", { "construction" : false, "index" : "5" });
                    skLineSegment(sketch, "df9M2iMwZqHF.1.0.1", { "construction" : false, "index" : "6" });
                    skLineSegment(sketch, "df9M2iMwZqHF.2.0.1", { "construction" : false, "index" : "7" });
                    skLineSegment(sketch, "df9M2iMwZqHF.3.0.1", { "construction" : false, "index" : "8" });
                    skLineSegment(sketch, "df9M2iMwZqHF.0.0.2", { "construction" : false, "index" : "9" });
                    skLineSegment(sketch, "df9M2iMwZqHF.1.0.2", { "construction" : false, "index" : "10" });
                    skLineSegment(sketch, "df9M2iMwZqHF.2.0.2", { "construction" : false, "index" : "11" });
                    skLineSegment(sketch, "df9M2iMwZqHF.3.0.2", { "construction" : false, "index" : "12" });
                    skLineSegment(sketch, "df9M2iMwZqHF.direction1", { "construction" : true, "index" : "13" });
                    skLineSegment(sketch, "df9M2iMwZqHF.direction2", { "construction" : true, "index" : "14" });
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localMidpoint" : "5wmPxsLl5s7z.middle", "localEntity1" : "5wmPxsLl5s7z.top.start", "localEntity2" : "5wmPxsLl5s7z.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.mid2", { "constraintType" : ConstraintType.MIDPOINT, "index" : "2", "name" : "", "localMidpoint" : "5wmPxsLl5s7z.middle", "localEntity1" : "5wmPxsLl5s7z.top.end", "localEntity2" : "5wmPxsLl5s7z.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "5wmPxsLl5s7z.top", "localSecond" : "5wmPxsLl5s7z.left" });
                    }
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "5wmPxsLl5s7z.bottom", "localSecond" : "5wmPxsLl5s7z.top" });
                    }
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "5wmPxsLl5s7z.left", "localSecond" : "5wmPxsLl5s7z.right" });
                    }
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "5wmPxsLl5s7z.top" });
                    }
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "5wmPxsLl5s7z.bottom.start", "localSecond" : "5wmPxsLl5s7z.left.start" });
                    }
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "5wmPxsLl5s7z.bottom.end", "localSecond" : "5wmPxsLl5s7z.right.start" });
                    }
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "5wmPxsLl5s7z.top.start", "localSecond" : "5wmPxsLl5s7z.left.end" });
                    }
                    {
                        skConstraint(sketch, "5wmPxsLl5s7z.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "5wmPxsLl5s7z.top.end", "localSecond" : "5wmPxsLl5s7z.right.end" });
                    }
                    {
                        var ywWlFmVnxRBWlt_query;
                        ywWlFmVnxRBWlt_query=qCompressed(1.0,"&227$eJxlkNtymzAQhl9GvWzHwgbCJQhhYweZrDRJ0xsGI9VWHCMM+JSnrzAznUlyJ+3Of/j2R+Sip5Nqb5nLN0iqVp+VTFpzCB0ysTPsIKm78rDR21PZa1PHZV+GOHO+b8StURxP0RrSecrCxyKmOWUxZeSVB8i0eqvr8r0L8d24RKrudX8bVFGJ6P8PnyEaz6lts9Ndb9px+IAI0FCka2YXplHtPTKVkYNSGWKO8S8PJezYduf58zyb/Nlv4mJ60a1aNzb9OCDejSTiKyrIoqBMpOKVK9TtVV/txgKp5BWS+7dm8lxHprtdwSW+bZSEhIIPDxCQakwLUHLadiVeBN5e+8ulX0xNQ699e5IKKovHX2guikE48AIejgYOTGE2XgBc8D5b/lQoyTuPc56/ieCDyaqYQQUSlC3VLPsgPh4Eyc6dleLZFy22+OISPeUevbyw35PF9S7G/vccfyj/F1i2g8c+XOXealm4G2PeVVmbJhofliFAKRMUOCXiH6Xlr6c=",id);
                        skConstraint(sketch, "5wmPxsLl5s7z.middle.positionSnap0", { "constraintType" : ConstraintType.CONCENTRIC, "index" : "1", "name" : "", "localFirst" : "5wmPxsLl5s7z.middle", "externalSecond" : qUnion([ywWlFmVnxRBWlt_query]) });
                    }
                    {
                        skConstraint(sketch, "7ftTPWqOkQWk", { "constraintType" : ConstraintType.EQUAL, "index" : "1", "name" : "", "localFirst" : "5wmPxsLl5s7z.bottom", "localSecond" : "5wmPxsLl5s7z.right" });
                    }
                    {
                        skConstraint(sketch, "jvAnVnfflxlo", { "constraintType" : ConstraintType.LENGTH, "index" : "1", "name" : "", "localFirst" : "5wmPxsLl5s7z.bottom", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('RailBlockNutWidth') - .1 * millimeter), 'expression' : "#RailBlockNutWidth-.1mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 2.7355063048973562, "labelDistance" : -0.001791496873716561 * meter });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.12.0.1.coi0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "df9M2iMwZqHF.1.0.1.start", "localSecond" : "df9M2iMwZqHF.2.0.1.start", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.12.0.1.coi1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "df9M2iMwZqHF.1.0.1.end", "localSecond" : "df9M2iMwZqHF.0.0.1.start", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.12.0.1.coi2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "name" : "", "localFirst" : "df9M2iMwZqHF.3.0.1.start", "localSecond" : "df9M2iMwZqHF.2.0.1.end", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.12.0.1.coi3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "name" : "", "localFirst" : "df9M2iMwZqHF.3.0.1.end", "localSecond" : "df9M2iMwZqHF.0.0.1.end", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.12.0.2.coi0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "9", "name" : "", "localFirst" : "df9M2iMwZqHF.1.0.2.start", "localSecond" : "df9M2iMwZqHF.2.0.2.start", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.12.0.2.coi1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "10", "name" : "", "localFirst" : "df9M2iMwZqHF.1.0.2.end", "localSecond" : "df9M2iMwZqHF.0.0.2.start", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.12.0.2.coi2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "11", "name" : "", "localFirst" : "df9M2iMwZqHF.3.0.2.start", "localSecond" : "df9M2iMwZqHF.2.0.2.end", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.12.0.2.coi3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "12", "name" : "", "localFirst" : "df9M2iMwZqHF.3.0.2.end", "localSecond" : "df9M2iMwZqHF.0.0.2.end", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.originJoin", { "constraintType" : ConstraintType.COINCIDENT, "index" : "13", "name" : "", "localFirst" : "df9M2iMwZqHF.direction1.start", "localSecond" : "df9M2iMwZqHF.direction2.start", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.hv1", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "2", "name" : "", "localFirst" : "df9M2iMwZqHF.direction1", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.hv2", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "name" : "", "localFirst" : "df9M2iMwZqHF.direction2", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.len2.c1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "14", "name" : "", "localFirst" : "df9M2iMwZqHF.direction2.start", "localSecond" : "5wmPxsLl5s7z.right.start", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.len2.c2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "15", "name" : "", "localFirst" : "df9M2iMwZqHF.direction2.end", "localSecond" : "df9M2iMwZqHF.0.0.1.start", "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.len2.length", { "constraintType" : ConstraintType.LENGTH, "index" : "2", "name" : "", "localFirst" : "df9M2iMwZqHF.direction2", "direction" : DimensionDirection.MINIMUM, "length" : 23.000000000000007 * millimeter, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.4999999999999997, "labelDistance" : -0.006115727959887046 * meter, "sketchToolType" : SketchToolType.PATTERN });
                    }
                    {
                        skConstraint(sketch, "df9M2iMwZqHF.pattern", { "constraintType" : ConstraintType.LINEAR_PATTERN, "index" : "1", "name" : "", "patterng" : { 'value' : try(roundWithinTolerance(12)), 'expression' : "" }.value, "patternc1" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "1" }.value, "previouspatternc1" : { 'value' : try(roundWithinTolerance(1)), 'expression' : "" }.value, "maximumpatterng" : { 'value' : try(roundWithinTolerance(12)), 'expression' : "" }.value, "patternc2" : { 'value' : try(roundWithinTolerance(3)), 'expression' : "3" }.value, "previouspatternc2" : { 'value' : try(roundWithinTolerance(3)), 'expression' : "" }.value, "localInstance0,0,0" : "5wmPxsLl5s7z.right", "localInstance1,0,0" : "5wmPxsLl5s7z.right.start", "localInstance2,0,0" : "5wmPxsLl5s7z.right.end", "localInstance3,0,0" : "5wmPxsLl5s7z.bottom", "localInstance4,0,0" : "5wmPxsLl5s7z.bottom.start", "localInstance5,0,0" : "5wmPxsLl5s7z.bottom.end", "localInstance6,0,0" : "5wmPxsLl5s7z.left", "localInstance7,0,0" : "5wmPxsLl5s7z.left.start", "localInstance8,0,0" : "5wmPxsLl5s7z.left.end", "localInstance9,0,0" : "5wmPxsLl5s7z.top", "localInstance10,0,0" : "5wmPxsLl5s7z.top.start", "localInstance11,0,0" : "5wmPxsLl5s7z.top.end", "localInstance0,0,1" : "df9M2iMwZqHF.0.0.1", "localInstance1,0,1" : "df9M2iMwZqHF.0.0.1.start", "localInstance2,0,1" : "df9M2iMwZqHF.0.0.1.end", "localInstance3,0,1" : "df9M2iMwZqHF.1.0.1", "localInstance4,0,1" : "df9M2iMwZqHF.1.0.1.start", "localInstance5,0,1" : "df9M2iMwZqHF.1.0.1.end", "localInstance6,0,1" : "df9M2iMwZqHF.2.0.1", "localInstance7,0,1" : "df9M2iMwZqHF.2.0.1.start", "localInstance8,0,1" : "df9M2iMwZqHF.2.0.1.end", "localInstance9,0,1" : "df9M2iMwZqHF.3.0.1", "localInstance10,0,1" : "df9M2iMwZqHF.3.0.1.start", "localInstance11,0,1" : "df9M2iMwZqHF.3.0.1.end", "localInstance0,0,2" : "df9M2iMwZqHF.0.0.2", "localInstance1,0,2" : "df9M2iMwZqHF.0.0.2.start", "localInstance2,0,2" : "df9M2iMwZqHF.0.0.2.end", "localInstance3,0,2" : "df9M2iMwZqHF.1.0.2", "localInstance4,0,2" : "df9M2iMwZqHF.1.0.2.start", "localInstance5,0,2" : "df9M2iMwZqHF.1.0.2.end", "localInstance6,0,2" : "df9M2iMwZqHF.2.0.2", "localInstance7,0,2" : "df9M2iMwZqHF.2.0.2.start", "localInstance8,0,2" : "df9M2iMwZqHF.2.0.2.end", "localInstance9,0,2" : "df9M2iMwZqHF.3.0.2", "localInstance10,0,2" : "df9M2iMwZqHF.3.0.2.start", "localInstance11,0,2" : "df9M2iMwZqHF.3.0.2.end", "localDirection1" : "df9M2iMwZqHF.direction1", "localDirection2" : "df9M2iMwZqHF.direction2", "labelDistance" : 0.005142693718135941 * meter, "labelAngle" : -0.7853981633974483 * radian, "label2Distance" : 0.005142693718135941 * meter, "label2Angle" : 2.356194490192345 * radian, "sketchToolType" : SketchToolType.PATTERN });
                    }
                    skSetInitialGuess(sketch, initialGuessF8wggogTepNUM5x_7);
                    skSolve(sketch);
                }
            };
        try(features.F8wggogTepNUM5x_7(id));
        features.FnriC59P8c1dqBR_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var scaiXWtfWpdcya_query;
                    scaiXWtfWpdcya_query=qCompressed(1.0,"&3af$eJyNktuSojAQhl8me6klICKXCFFROUySnVn3hkKSwYxCEOJpnn7jYS1dp7bmJpWk8/39d3d+DEzwsmX1MTCxpgPKm7RY8HybSi5KL5WpowX6c4QcK4b7gERxNItGc7VlpeSSs8YxHd3tKLUFoKzmO0aHtSjON+nl0fEED1IAbwfcBdAbQYUseSNFfbzKuwg6xI9CFRAVq8+ZfTrQgU8dDWtauweG/X2ei5ywKvwZmIfE2vOaRRW2weZU1VmIAjyFxB0nMCQ+mWMGmhWT2fJiwKc4U0LmvogPzWxtNtbnQkgpCmSiHrJQH9luptK1aNsCvKhqXkqUYQv4QYz8kHgt7VIx6p7XG4UWKEMUMdzSjLYBpKjuYpqugprhfYftgjV7l88w0tJv0Caoeb78Ejcf8O711DmNHKn+GiBC/sgPnVniwRiGHgzdueqsUIK8TNeNoz3mPfdJjaXFwDDc1M1u9DoKOr9XCy8xro4yQFcfVee1HIjmeECma6nhDx0XPirYYLjNm1Qb270VtyYTKzFEBQ+y3lKmmp8C/AZjkpzAe89I7yLd/J+tuOlhjOMPYn+GNEu6N1vVRNrepiBusGsUqtN/WF39NbIfvMQ9uH8Lf3XGhzNsdJ7zWCf77ygMlmgmnWncm04ScyHEmqWlqAaXjarCBur7QIShS76czp2Nv7d/AL6wH3k=",id);
                    var hOpIznKhzExkvp_query;
                    hOpIznKhzExkvp_query=qCompressed(1.0,"&401$eJyVUsly4jAU/BnNEcryGh+NLcAkXiJpkiEXl7AEUQi2sUWAfP2IZaiQpKZmLiotr/t1P/WPgQPuN6LdJw6BJuCyY6uZXGyYknUVMcUCmJhfX+i+EeQG0CzP7rLRVG9FpaSSogucwAwNzTYDXLTyTfBhW6+ON+xUtD+ABwygy4HYAEUjpCHPslN1uz/ThxgFNM5S/VA3oj12jvnABDEPIIGw74LhzXaxqBdUNOnPxNkV3la2ImuID9YHV0ciDsgtouG4QCmN6ZQI0C2FKp9PAmJOyj7s96Ddh4DP/cSUyfZpPR4aJnawiz18g/2w1A17vO8BuWpaWSlcEg/ESY7jlEY9ePKM7eN6QeEZLjHHgvSgdW7Rgw6AHyqgqUughaHzDxQafCH5yhH9nwrrOxXiisI+n4xDCLCeuAUyHI/iNLgrIpSjNEJpONWzrlu5kBV77QJ43fs4N/1RPQGG6brt3kYPo8R4Ws6iwjqrKgFfvjTGQzWou/0OO6Gn4zAMQnTN4IPhZtExOPbdpfQmE6+w6gbtVLvhQn8GA+QR5bQ4ALUE9+zgrBybNjadv4nLO5cQkr9Q/z3lZWFfxDUT5UfrFQ2Tt05DTf4Ja+oM0u3gPnfR9jH9ZYx3R7BlXIo1iaw6xapSpGwlEHSuXM1xmjzjOxXc5u7tpHDqJmdKibbSrmwQZvn0cwzNed/TyFldvwpW1c3gtNH1PtBxRJigkH6bsQ8G/tz+BueXMiI=",id);
                    var bPQjxJqfeqlWgm_query;
                    bPQjxJqfeqlWgm_query=qCompressed(1.0,"&401$eJyNUtt2ojAU/ZnMoy7CtTwiREXLpUmmHfvCiiRqagUErDpfPxEdp7Zds/oCuZy9z94n+8fAAg87UR8ji0AdcNmwzVwud6yVZRGwlnkw0j/f0GMlyB2gSZrcJ6OZWoqila0UjWd5uq8ptjngopZvgg/rctOdsHPR8QQeMICuG2ICFIyQgqxk05b18ULvY+TRMInVRVmJuusc8oEOQu5BAmHfBsO7/XJZLqmo4p+RdcicvaxFUhEXbE+uOiIOyBRRf5yhmIZ0RgRo1qLNV2cBISd5H/Z70OxDwBdupMto/7wdDzWILWxjB99h189Vwx7vO0BuqloWLc6JA8IoxWFMgx48e8Zm972i8BznmGNBetBQDayuifqDdyVQVzXQwND6Bge8MuifKYLvqPjHYHwlQtxQmJeddgoBVhM3QILDURh791mAUhQHKPZnatZlLZeyYK+NB297d3NTD9UTYBhv6+Zt9DiKtOf1PMiMi6oc8PVLpT0Wg7I5HrDlOyoOQ89HtwwuGO6WDYNj115LZzJxMqOs0KGtd1yox2CAPKGUZiegkmBfHFyUY93EuvU/cWljE0LSF+r+jnmemVdx1aR1g+2G+tFbo6A6/4DVVQbpfvCQ2mj/FP/SxocObGjXYkUii6ZlRS5ithEIWjeuFjiOVvi+9aapPZ1kVlmlrG1FXShXJvCTdPYxhvqi7yjkvCxfBSvKanBeqHoXqDgiTJBPv4zYOwN/T/8A4soyIg==",id);
                    var LrJaXaeGWpjOal_query;
                    LrJaXaeGWpjOal_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    annotation { "Feature Name" : "Extrude 8" }
                    extrude(context, id + "FnriC59P8c1dqBR_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.REMOVE, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([scaiXWtfWpdcya_query, hOpIznKhzExkvp_query, bPQjxJqfeqlWgm_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(lookup('RailBlockNutDepth')), 'expression' : "#RailBlockNutDepth" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([LrJaXaeGWpjOal_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FnriC59P8c1dqBR_7(id));
        features.FvWr5emyZpPuFch_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFvWr5emyZpPuFch_7 = { "GByKvXTu1okX.bottom" : [-0.02648, 0.09509736546277997, -1.0, 1.2246467991473532E-16, -0.002850000000000002, 0.0028499999999999984], "GByKvXTu1okX.top" : [-0.02648, 0.10079736546277997, -1.0, 1.2246467991473532E-16, -0.0028500000000000053, 0.002849999999999995], "GByKvXTu1okX.left" : [-0.023629999999999998, 0.09866852269052433, 6.123233995736766E-17, 1.0, -0.0035711572277443565, 0.0021288427722556402], "GByKvXTu1okX.right" : [-0.02933, 0.09866852269052433, 6.123233995736766E-17, 1.0, -0.0035711572277443565, 0.0021288427722556402], "GByKvXTu1okX.middle" : [-0.026480000000000004, 0.09794736546277996] };
                    {
                    }
                    var nZSPefJaGRNECU_query;
                    nZSPefJaGRNECU_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$3ZamyaBeXbFHR4C6S4$FACER6R7R8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbSa$SWEPT_FACE",id);
                    annotation { "Feature Name" : "Sketch 6" }
                    var sketch = newSketch(context, id + "FvWr5emyZpPuFch_7", { "sketchPlane" : qUnion([nZSPefJaGRNECU_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                    skLineSegment(sketch, "GByKvXTu1okX.bottom", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "GByKvXTu1okX.top", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "GByKvXTu1okX.left", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "GByKvXTu1okX.right", { "construction" : false, "index" : "4" });
                    skPoint(sketch, "GByKvXTu1okX.middle", { "construction" : true, "index" : "1" });
                    {
                        skConstraint(sketch, "GByKvXTu1okX.mid1", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localMidpoint" : "GByKvXTu1okX.middle", "localEntity1" : "GByKvXTu1okX.top.start", "localEntity2" : "GByKvXTu1okX.bottom.end" });
                    }
                    {
                        skConstraint(sketch, "GByKvXTu1okX.mid2", { "constraintType" : ConstraintType.MIDPOINT, "index" : "2", "name" : "", "localMidpoint" : "GByKvXTu1okX.middle", "localEntity1" : "GByKvXTu1okX.top.end", "localEntity2" : "GByKvXTu1okX.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "GByKvXTu1okX.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "GByKvXTu1okX.top", "localSecond" : "GByKvXTu1okX.left" });
                    }
                    {
                        skConstraint(sketch, "GByKvXTu1okX.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "GByKvXTu1okX.bottom", "localSecond" : "GByKvXTu1okX.top" });
                    }
                    {
                        skConstraint(sketch, "GByKvXTu1okX.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "GByKvXTu1okX.left", "localSecond" : "GByKvXTu1okX.right" });
                    }
                    {
                        skConstraint(sketch, "GByKvXTu1okX.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "GByKvXTu1okX.top" });
                    }
                    {
                        skConstraint(sketch, "GByKvXTu1okX.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "GByKvXTu1okX.bottom.start", "localSecond" : "GByKvXTu1okX.left.start" });
                    }
                    {
                        skConstraint(sketch, "GByKvXTu1okX.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "GByKvXTu1okX.bottom.end", "localSecond" : "GByKvXTu1okX.right.start" });
                    }
                    {
                        skConstraint(sketch, "GByKvXTu1okX.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "GByKvXTu1okX.top.start", "localSecond" : "GByKvXTu1okX.left.end" });
                    }
                    {
                        skConstraint(sketch, "GByKvXTu1okX.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "GByKvXTu1okX.top.end", "localSecond" : "GByKvXTu1okX.right.end" });
                    }
                    {
                        var XDbEJGnXsYArBR_query;
                        XDbEJGnXsYArBR_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromA2C0M5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$3ZamyaBeXbFHR5C7S4$FACER7R8R9CcA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRcSa$SWEPT_FACEC0M5R1A1M2R2R3R4A1C0M5R5R6R7R8R9CcA1S11.-e$FEgylpGpriUs7TI_4RcRdReSc$rlji1LmZW4AeR5R14R7R8R9CcA1S11.-16$F5hLjtWl45gnYnz_4RcR17R5R6R7R8R9CcA1S11.9$FOXGwrJD83Ktmdd_5opBooleanRcS9$INTERSECT",id);
                        skConstraint(sketch, "GByKvXTu1okX.middle.positionSnap0", { "constraintType" : ConstraintType.CONCENTRIC, "index" : "1", "name" : "", "localFirst" : "GByKvXTu1okX.middle", "externalSecond" : qUnion([XDbEJGnXsYArBR_query]) });
                    }
                    {
                        skConstraint(sketch, "bXGnB1vU1ePo", { "constraintType" : ConstraintType.EQUAL, "index" : "1", "name" : "", "localFirst" : "GByKvXTu1okX.left", "localSecond" : "GByKvXTu1okX.top" });
                    }
                    {
                        skConstraint(sketch, "4EiL6XfRZxvI", { "constraintType" : ConstraintType.LENGTH, "index" : "1", "name" : "", "localFirst" : "GByKvXTu1okX.left", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(lookup('RailBlockNutWidth') - .1 * millimeter), 'expression' : "#RailBlockNutWidth-.1mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 1.1992783779670309, "labelDistance" : 0.013240046250782813 * meter });
                    }
                    skSetInitialGuess(sketch, initialGuessFvWr5emyZpPuFch_7);
                    skSolve(sketch);
                }
            };
        try(features.FvWr5emyZpPuFch_7(id));
        features.FzzCkTGimeXnXxY_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var VIuxPQPsatqjxt_query;
                    VIuxPQPsatqjxt_query=qCompressed(1.0,"&3a6$eJyNkllz2jAUhf+M+giDvGB49CI7ZrGp7JblxSMsFRSw5ciCxP31FSRlQpPp5MUj6fo79+geffNs8P3EZDe3M2gAyltSbfnuRBQXdUAUceHc+FjJu4ZlI5Cni3SWRmu9ZLXiirPWtV3DH2i1LaBM8jOjoRTV9YS8/tRdYI8AdNtkFkBBhDSy560SsnuT9zFy8zhNdEE0TF47x9QzQExdmEHYH4LwvJQ2q7pNsziF5b5wnrlkaZONwdPlVlchCrIpyv2HAiV5nK8zBtoDU+X+1UBMs1ILRV43Pa/yExSH1VYoJSps4yF28AiP/VK369G+A3jVSF4rXGYOiOcLHCd50IOvN8bW9Xuj8BaXmGKW9aDZN4ESzbsaNHQRmsFXWAsc2S/1EcaQfIG2geS7/ae4fYdbb7vBJXKs52uCFMdRnLizIkALlAQo8dd6skIL8pocWxfe973OScfSYyBMnmR7jn5G88HmsA0K881RCcwNqTrisdU2fMC27+jwQ9dH9wpjEJ52LYEP4+GBO5OJU5iiQS9KnijTwycgW6JFXlzA956xYWHD/p8ttOuOTaRD/NE6eVxYN1vy+MjhrNosLZdp1KD/sIZ+a/Z+9qiWR8ve1ev69xU2Bx/7aPPpKnqWk2BkTlVFaWGLxhPiyEitzY+BfjUIZ8jPPw3lXfe/p38A2V8c0Q==",id);
                    var sJCdXFJvOzOygI_query;
                    sJCdXFJvOzOygI_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    annotation { "Feature Name" : "Extrude 9" }
                    extrude(context, id + "FzzCkTGimeXnXxY_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.REMOVE, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([VIuxPQPsatqjxt_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(lookup('RailBlockNutDepth')), 'expression' : "#RailBlockNutDepth" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([sJCdXFJvOzOygI_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FzzCkTGimeXnXxY_7(id));
        features.FHpmxK3OWCIyRoo_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (!switch (configuration.List_5KGcbwyvF0AOZo) { List_5KGcbwyvF0AOZo_conf.Default : false, List_5KGcbwyvF0AOZo_conf.Sharp : true, List_5KGcbwyvF0AOZo_conf.Bevel : true })
                {
                    {
                    }
                    var xvXsEJtrvCMkFb_query;
                    xvXsEJtrvCMkFb_query=qCompressed(1.0,"&25d$eJxtkFtTo0AQhf/M7KMWQwIhj1yGS0UI28OulScKmFaGGAaBqPx7IbG0Sn2c7p5zvnP+OAb5e8Z+ig1eEoG9fEHh9+pk6642z6hOhByKUykfz8UoVesVY2HTWP+5yaYOOV2RPURBlNh3ucdSlngscQ98S1QvH2VbPA0fwgXBdpTjtPxyCsI+H3xNmBewmaaWw6j669AiLjA7i/bJvFAd9hfLSDg6iYRNOaW3JvFlMDQ2X+9MzSoeqlx7lT3uu9n9eYl4ERKE71jmhjlLsig7cCTDEceqvgJEgleEh6VfWacDYrJZWMEAEzZgwRZKqEAAzkdd+O9YQlayV25+HbjVlWVL/NivvYdD86w3u7Md55rq2NvYnwVCNYfn9yzN8iXoxYEulYIOK1hf+/kpeYPEV9NRlzQW91nb3dW5/kkTQ+m0GGxGwO03ZPrF3Hb4UsvgfyoY/cWAzg02a9g40ahUeAqn9OJArV/z6Y5jaN4x26m0QTNfqc5R6gmLds5nkJhBwN4BVrm/gQ==",id);
                    var JUIkzcfybGrxNT_query;
                    JUIkzcfybGrxNT_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$MRbBneG7tRe9C0M5R4R5R6R7R8RaRbRcRdSc$npevhiGVPdE1R4R5R6R7R8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$SWEPT_EDGE",id);
                    var bEJdijJVFMlYWa_query;
                    bEJdijJVFMlYWa_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$npevhiGVPdE1C0M5R4R5R6R7R8RaRbRcRdSc$quFEu4ZacbDGR4R5R6R7R8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$SWEPT_EDGE",id);
                    var xwoOrONMAvTCMB_query;
                    xwoOrONMAvTCMB_query=qCompressed(1.0,"&25d$eJxtkEtzozAQhP+M9pgthAHbRx4CUzaYHbGb8l4ogZQgiBHmkYR/H7C34qpNjpoZdX/dPxwT/RpFN0UmzREXnXwV3O/U2dZdbZ5hHXHZs3Mun0c2SNV4bGA2jvSvm3RqBcUrdIQwCGP7kHkkIbFHYvdEt0h18lk27KX/J8yQaAY5TMsvhyHy+aAGIl5AZppS9oPqbsMNcoHYaXiM54VqRXe1DLmjo5DbmGL800K+DPrKpsbe0jbsqci0N9mJYzu7X5aIVyGO6J6k7i4jcRqmJypQX4uhKG8AIacFiqChvXfQ6rUGCyuYYMEaNrCFHArgIOajdve7ziHNyRu17gducWPZIj/yS+/pVF30aj/aUaaplrwP3cgFFHN4+kiSNFuCXh3wUinosALj1s9XyQeBfDXVusQRf0yb9lBm+idN04rXUgZ/Ek7wf8j4znwZfTIaf1mRe8E3BnhusDJg7YSDUrvzbkquDnjzbT7dcUzNq9O9SiphZSvVOkq9CNbM+UwUEQjIBy0Jv3I=",id);
                    annotation { "Feature Name" : "Lower Edges Fillet" }
                    fillet(context, id + "FHpmxK3OWCIyRoo_7", { "filletType" : FilletType.EDGE, "entities" : qUnion([xvXsEJtrvCMkFb_query, JUIkzcfybGrxNT_query, bEJdijJVFMlYWa_query, xwoOrONMAvTCMB_query]), "side1Face" : qUnion([]), "side2Face" : qUnion([]), "centerFaces" : qUnion([]), "tangentPropagation" : true, "blendControlType" : BlendControlType.RADIUS, "crossSection" : FilletCrossSection.CIRCULAR, "radius" : { 'value' : try(lookup('Lower_Round')), 'expression' : "#Lower_Round" }.value, "nonCircularRadius" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "width" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "rho" : { 'value' : try(0.5), 'expression' : "0.5" }.value, "magnitude" : { 'value' : try(0.5), 'expression' : "0.5" }.value, "defaultsChanged" : true, "isAsymmetric" : false, "otherRadius" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipAsymmetric" : false, "isPartial" : false, "startPartialType" : EndTypePartialFillet.PERCENTAGE, "startPartialOffset" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "startPartialEntity" : qUnion([]), "partialFirstEdgeTotalParameter" : { 'value' : try(0.01), 'expression' : "0.01" }.value, "partialOppositeParameter" : true, "useTrimmedFirstBound" : false, "secondBound" : false, "endPartialType" : EndTypePartialFillet.PERCENTAGE, "endPartialOffset" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endPartialEntity" : qUnion([]), "useTrimmedSecondBound" : false, "partialSecondEdgeTotalParameter" : { 'value' : try(0.99), 'expression' : "0.99" }.value, "isVariable" : false, "vertexSettings" : [], "pointOnEdgeSettings" : [], "smoothTransition" : false, "allowEdgeOverflow" : true, "keepEdges" : qUnion([]), "smoothCorners" : false, "smoothCornerExceptions" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FHpmxK3OWCIyRoo_7(id));
        features.Fqk6yoVrBbiGN3j_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFqk6yoVrBbiGN3j_7 = {};
                    {
                    }
                    var bqUHtEkxkJhEjc_query;
                    bqUHtEkxkJhEjc_query=qCompressed(1.0,"&1c8$eJx1UE1Pg0AQ/TPj1bhIKRxhWZBYKM6SmnohC2zKpgp0WbT8e0ubeDE9zsyb9/UQrOBtknpOHU4saNQovip1mIRRfRcKI3ySWv8vxTxITp5hi0mcZP6mDFnOspBldM896LU6qE58jr5Nn9IVFyA7o8y8fAUC2N/AbWBhzHgFrRpNr29LFygyv0i22eXQD1JfJZMmsCBpfMIJeXQg6uejpUjavBfdsGlL60dpuR0u6qclzpWoAf7KCvpSsqxIij2XMB6lqdubgaThNRBnntUuGM/co4tXtHGFDq7RRYEV1riAUqyCTsZrg9K7C+oG+d2qeJc3jNwFnaaITfaHqKswRps6lwIin7IFx9egRm6ENhG6tLrl9CCKXXs37WJXtnnR6dLuB3Y2emokVktTfl4uDL8/YpSJ",id);
                    annotation { "Feature Name" : "Sketch 1" }
                    var sketch = newSketch(context, id + "Fqk6yoVrBbiGN3j_7", { "sketchPlane" : qUnion([bqUHtEkxkJhEjc_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                    skSetInitialGuess(sketch, initialGuessFqk6yoVrBbiGN3j_7);
                    skSolve(sketch);
                }
            };
        try(features.Fqk6yoVrBbiGN3j_7(id));
        features.FlO66UHASJM1bnu_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFlO66UHASJM1bnu_7 = { "UkO4Vsgr2YPI.bottom" : [-0.08684582449495792, -0.041801085472106925, -1.0, 0.0, -0.022705880050880117, 0.01729411994911989], "UkO4Vsgr2YPI.top" : [-0.08684582449495792, -0.06180108547210694, -1.0, 0.0, -0.022705880050880117, 0.01729411994911989], "UkO4Vsgr2YPI.left" : [-0.0641399444440778, -0.051801085472106934, 3.0616169978683826E-16, -1.0, -0.009999999999999981, 0.010000000000000009], "UkO4Vsgr2YPI.right" : [-0.10413994444407781, -0.051801085472106934, 0.0, -1.0, -0.010000000000000009, 0.010000000000000009], "tHYPblrAKD8F.bottom" : [-0.07751693576574326, -0.06180108547210694, -1.0, 0.0, -0.007230572402477264, 0.010874323546886444], "tHYPblrAKD8F.top" : [-0.07751693576574326, -0.04559116065502167, -1.0, 0.0, -0.007230572402477264, 0.010874323546886444], "tHYPblrAKD8F.left" : [-0.07028636336326599, -0.053696123063564305, 0.0, 1.0, -0.008104962408542637, 0.008104962408542637], "tHYPblrAKD8F.right" : [-0.0883912593126297, -0.053696123063564305, 0.0, 1.0, -0.008104962408542637, 0.008104962408542637], "leaO3WrHq7qY.bottom" : [-0.07933881133794785, -0.05253706872463226, 1.0, 0.0, -0.009052447974681854, 0.009052447974681854], "leaO3WrHq7qY.top" : [-0.07933881133794785, -0.06180108547210694, 1.0, 0.0, -0.009052447974681854, 0.009052447974681854], "leaO3WrHq7qY.left" : [-0.0883912593126297, -0.0571690770983696, 0.0, -1.0, -0.00463200837373734, 0.00463200837373734], "leaO3WrHq7qY.right" : [-0.07028636336326599, -0.0571690770983696, 0.0, -1.0, -0.00463200837373734, 0.00463200837373734] };
                    {
                    }
                    var JRzJxSGoVAkllj_query;
                    JRzJxSGoVAkllj_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S3.7$TopplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 2" }
                    var sketch = newSketch(context, id + "FlO66UHASJM1bnu_7", { "sketchPlane" : qUnion([JRzJxSGoVAkllj_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                    skLineSegment(sketch, "UkO4Vsgr2YPI.bottom", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "UkO4Vsgr2YPI.top", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "UkO4Vsgr2YPI.left", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "UkO4Vsgr2YPI.right", { "construction" : false, "index" : "4" });
                    skLineSegment(sketch, "tHYPblrAKD8F.bottom", { "construction" : false, "index" : "5" });
                    skLineSegment(sketch, "tHYPblrAKD8F.top", { "construction" : false, "index" : "6" });
                    skLineSegment(sketch, "tHYPblrAKD8F.left", { "construction" : false, "index" : "7" });
                    skLineSegment(sketch, "tHYPblrAKD8F.right", { "construction" : false, "index" : "8" });
                    skLineSegment(sketch, "leaO3WrHq7qY.bottom", { "construction" : false, "index" : "9" });
                    skLineSegment(sketch, "leaO3WrHq7qY.top", { "construction" : false, "index" : "10" });
                    skLineSegment(sketch, "leaO3WrHq7qY.left", { "construction" : false, "index" : "11" });
                    skLineSegment(sketch, "leaO3WrHq7qY.right", { "construction" : false, "index" : "12" });
                    {
                        skConstraint(sketch, "UkO4Vsgr2YPI.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "UkO4Vsgr2YPI.top", "localSecond" : "UkO4Vsgr2YPI.left" });
                    }
                    {
                        skConstraint(sketch, "UkO4Vsgr2YPI.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "UkO4Vsgr2YPI.bottom", "localSecond" : "UkO4Vsgr2YPI.top" });
                    }
                    {
                        skConstraint(sketch, "UkO4Vsgr2YPI.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "UkO4Vsgr2YPI.left", "localSecond" : "UkO4Vsgr2YPI.right" });
                    }
                    {
                        skConstraint(sketch, "UkO4Vsgr2YPI.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "UkO4Vsgr2YPI.top" });
                    }
                    {
                        skConstraint(sketch, "UkO4Vsgr2YPI.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "UkO4Vsgr2YPI.bottom.start", "localSecond" : "UkO4Vsgr2YPI.left.start" });
                    }
                    {
                        skConstraint(sketch, "UkO4Vsgr2YPI.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "UkO4Vsgr2YPI.bottom.end", "localSecond" : "UkO4Vsgr2YPI.right.start" });
                    }
                    {
                        skConstraint(sketch, "UkO4Vsgr2YPI.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "UkO4Vsgr2YPI.top.start", "localSecond" : "UkO4Vsgr2YPI.left.end" });
                    }
                    {
                        skConstraint(sketch, "UkO4Vsgr2YPI.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "UkO4Vsgr2YPI.top.end", "localSecond" : "UkO4Vsgr2YPI.right.end" });
                    }
                    {
                        skConstraint(sketch, "oksRs9JJj9Zt", { "constraintType" : ConstraintType.LENGTH, "index" : "1", "name" : "", "localFirst" : "UkO4Vsgr2YPI.right", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(20 * millimeter), 'expression' : "20 mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : -0.411197049263918, "labelDistance" : 0.024543389678001404 * meter });
                    }
                    {
                        skConstraint(sketch, "AsxY1ec3kOVE", { "constraintType" : ConstraintType.LENGTH, "index" : "2", "name" : "", "localFirst" : "UkO4Vsgr2YPI.bottom", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(40 * millimeter), 'expression' : "40 mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 1.2524788106612463, "labelDistance" : 0.01260681800544261 * meter });
                    }
                    {
                        skConstraint(sketch, "tHYPblrAKD8F.firstSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "tHYPblrAKD8F.bottom.start", "localSecond" : "UkO4Vsgr2YPI.top" });
                    }
                    {
                        skConstraint(sketch, "tHYPblrAKD8F.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "2", "name" : "", "localFirst" : "tHYPblrAKD8F.top", "localSecond" : "tHYPblrAKD8F.left" });
                    }
                    {
                        skConstraint(sketch, "tHYPblrAKD8F.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "3", "name" : "", "localFirst" : "tHYPblrAKD8F.bottom", "localSecond" : "tHYPblrAKD8F.top" });
                    }
                    {
                        skConstraint(sketch, "tHYPblrAKD8F.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "4", "name" : "", "localFirst" : "tHYPblrAKD8F.left", "localSecond" : "tHYPblrAKD8F.right" });
                    }
                    {
                        skConstraint(sketch, "tHYPblrAKD8F.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "2", "name" : "", "localFirst" : "tHYPblrAKD8F.top" });
                    }
                    {
                        skConstraint(sketch, "tHYPblrAKD8F.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "tHYPblrAKD8F.bottom.start", "localSecond" : "tHYPblrAKD8F.left.start" });
                    }
                    {
                        skConstraint(sketch, "tHYPblrAKD8F.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "7", "name" : "", "localFirst" : "tHYPblrAKD8F.bottom.end", "localSecond" : "tHYPblrAKD8F.right.start" });
                    }
                    {
                        skConstraint(sketch, "tHYPblrAKD8F.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "8", "name" : "", "localFirst" : "tHYPblrAKD8F.top.start", "localSecond" : "tHYPblrAKD8F.left.end" });
                    }
                    {
                        skConstraint(sketch, "tHYPblrAKD8F.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "9", "name" : "", "localFirst" : "tHYPblrAKD8F.top.end", "localSecond" : "tHYPblrAKD8F.right.end" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.firstSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "10", "name" : "", "localFirst" : "leaO3WrHq7qY.bottom.start", "localSecond" : "tHYPblrAKD8F.right" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.oppositeSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "11", "name" : "", "localFirst" : "leaO3WrHq7qY.top.end", "localSecond" : "tHYPblrAKD8F.bottom.start" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.perpendicular", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "3", "name" : "", "localFirst" : "leaO3WrHq7qY.top", "localSecond" : "leaO3WrHq7qY.left" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.parallel.1", { "constraintType" : ConstraintType.PARALLEL, "index" : "5", "name" : "", "localFirst" : "leaO3WrHq7qY.bottom", "localSecond" : "leaO3WrHq7qY.top" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.parallel.2", { "constraintType" : ConstraintType.PARALLEL, "index" : "6", "name" : "", "localFirst" : "leaO3WrHq7qY.left", "localSecond" : "leaO3WrHq7qY.right" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.horizontal", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "3", "name" : "", "localFirst" : "leaO3WrHq7qY.top" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.corner0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "12", "name" : "", "localFirst" : "leaO3WrHq7qY.bottom.start", "localSecond" : "leaO3WrHq7qY.left.start" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.corner1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "13", "name" : "", "localFirst" : "leaO3WrHq7qY.bottom.end", "localSecond" : "leaO3WrHq7qY.right.start" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.corner2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "14", "name" : "", "localFirst" : "leaO3WrHq7qY.top.start", "localSecond" : "leaO3WrHq7qY.left.end" });
                    }
                    {
                        skConstraint(sketch, "leaO3WrHq7qY.corner3", { "constraintType" : ConstraintType.COINCIDENT, "index" : "15", "name" : "", "localFirst" : "leaO3WrHq7qY.top.end", "localSecond" : "leaO3WrHq7qY.right.end" });
                    }
                    skSetInitialGuess(sketch, initialGuessFlO66UHASJM1bnu_7);
                    skSolve(sketch);
                }
            };
        try(features.FlO66UHASJM1bnu_7(id));
        features.FbjaK3hNI0J67Ef_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var jefduMNoVuoPkG_query;
                    jefduMNoVuoPkG_query=qCompressed(1.0,"&46d$eJydkltz2jAQhf/M9hEGyTd4FEYENwXTlZOUp4wvAjQBbGTRDv++sklbMgmUyZul3fPtOSt/GXrw/SD1ceoJQqFQdbrN1OqQGlXuRqlJGZnS95XkWEnRhySex9/iu4X9lDujjJI18xkNe5aWQSG1+imLsS637U16ajo24mEK/O9BuMBHd9xK1qo2pT6+4kPkLInimS2UldTt5KgYUogKRgQhXR/Gm9j3HyZMfJ2SbHd4Dn4pLeNKDGDfpGpBBYh7noSTZz5LomQhJNQv0uTrk4GoELkFPbzE7mO90nQxj7LSmHKLHvoYYB8HYW7HdYpuAGpbabUzmIsAoukco1kyIm1gH90m5D8RZphjgVJ0iNN1wJQV9pplIkGKDqOnNaHL7E3/itSFjVwa9MJA+PDIMeE/XrsItT4GYD1wFDxMRh1yCzTvdkgGZrKYZxvN7kf9sW0i+RkUSYHkXHq6dJAs/2S1+M/F8UCr1dp8PPI2yLLboQQ+JCyvm6b0kulrw8gAGuX/HNNLkGbhzSumsfOkJ/tgv/iMd4e89Y6OezbcVt3e7e/oXcSeM7OmeiE2uukFy177r7owZiF/W/sNCnlF6g==",id);
                    var EHtYjhCVacsojL_query;
                    EHtYjhCVacsojL_query=qCompressed(1.0,"&2e6$eJx9UNty2jAQ/ZntIwySrzwKWwQ3BZOV05anjGwrQVPARohm+PsIO0nJhOZN2j2XPefbJIC7ozKneSAIhVof5LbUT0dpdbNLpZWMzOnnTXFqlYihyJf5j/xm5Z5qZ7XV6sB8RpORUyuhVkb/VfXUNNtuInvQ6UyeSODvH+EDT2+4o6z1wTbm9CqfIGdFli/commV6ZyzekIhqxkRhAxDmG7yMLyfMfF9Tsrd8SF61kblrRjD/pyqE6pB3PIimT3wRZEVK6Hg8EfZat0fkNWiGnpgZ6tluTHsNo2ntmkxwBAjjHGcVM5rUA8j0NvW6J3FSkSQzZeYLYqUdGlD9M8J/5GwxAprVGJAvKEPG/VocXSuEglS9BjtS0JXFpIRkhiDJBIh/ORY8N+vGoQ6qzE4G46CJwWS4JIW/8eycrVslMy9X2a2j/arsrG22TogkRfCSMp0QC7o/dB7M/k6UgBGP62/zETlFcuPERyEPF5DUXrlMPpu0LM+H96V6MOUJfzj7gVm+t2N",id);
                    var BuMLveShtAeqVb_query;
                    BuMLveShtAeqVb_query=qCompressed(1.0,"&309$eJyNUV1z2jAQ/DPqIwwnbBkejS2CmxrTk5PUTxl/CNAEsJFFO/z7CJum+epM3k63t7e7um8zl/w8SX2OXQGUVKrN94XanHKj6kOYm9yHmH5E0nMjxYSkySr5kdxktpQHo4ySre/4NBjFTBSkklr9ltVc13vbcUXeD50v5FlO+MtDOISHN9xStqo1tT5f1wfI/TRKlhaoG6k75aiaURJVPgiAISPzXcLY3cIX32MoDqdH74/SMmnElBwvqbpFFRG3PA0Wj3yZRmkmJGmfpCm3vYGoEuVwTO6eEue+3WiarSJTNzi6BEdAimOfdpFctNEQRl3pIkMPJzjFAkusUNolDjGLbFXstH8bTuY7uTboBp5g5J5jyn/180FprQ+qoUfUvtHqYLC0ZqNlylHwIA0H8BWxAbChS7TabK0GgnOFgVkcvBBeUS494ZEoXqFVQZj290EHgb5NiZC/1qb/DcrITubJ+EEvjt4xK2pj6v0nNhDW73wgtarrfwbK99+MIP86vLqwnMnXd79Qe9ZHvLuIQ+Z+wN9iz92N5zg=",id);
                    annotation { "Feature Name" : "Extrude 1" }
                    extrude(context, id + "FbjaK3hNI0J67Ef_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.NEW, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([jefduMNoVuoPkG_query, EHtYjhCVacsojL_query, BuMLveShtAeqVb_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FbjaK3hNI0J67Ef_7(id));
        features.F5SfC2e9JmcTfXk_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var IODYdIAwyKyoHf_query;
                    IODYdIAwyKyoHf_query=qCompressed(1.0,"&2e6$eJx9UNty2jAQ/ZntIwySrzwKWwQ3BZOV05anjGwrQVPARohm+PsIO0nJhOZN2j2XPefbJIC7ozKneSAIhVof5LbUT0dpdbNLpZWMzOnnTXFqlYihyJf5j/xm5Z5qZ7XV6sB8RpORUyuhVkb/VfXUNNtuInvQ6UyeSODvH+EDT2+4o6z1wTbm9CqfIGdFli/commV6ZyzekIhqxkRhAxDmG7yMLyfMfF9Tsrd8SF61kblrRjD/pyqE6pB3PIimT3wRZEVK6Hg8EfZat0fkNWiGnpgZ6tluTHsNo2ntmkxwBAjjHGcVM5rUA8j0NvW6J3FSkSQzZeYLYqUdGlD9M8J/5GwxAprVGJAvKEPG/VocXSuEglS9BjtS0JXFpIRkhiDJBIh/ORY8N+vGoQ6qzE4G46CJwWS4JIW/8eycrVslMy9X2a2j/arsrG22TogkRfCSMp0QC7o/dB7M/k6UgBGP62/zETlFcuPERyEPF5DUXrlMPpu0LM+H96V6MOUJfzj7gVm+t2N",id);
                    var HAEElRPASborZK_query;
                    HAEElRPASborZK_query=qCompressed(1.0,"&309$eJyNUV1z2jAQ/DPqIwwnbBkejS2CmxrTk5PUTxl/CNAEsJFFO/z7CJum+epM3k63t7e7um8zl/w8SX2OXQGUVKrN94XanHKj6kOYm9yHmH5E0nMjxYSkySr5kdxktpQHo4ySre/4NBjFTBSkklr9ltVc13vbcUXeD50v5FlO+MtDOISHN9xStqo1tT5f1wfI/TRKlhaoG6k75aiaURJVPgiAISPzXcLY3cIX32MoDqdH74/SMmnElBwvqbpFFRG3PA0Wj3yZRmkmJGmfpCm3vYGoEuVwTO6eEue+3WiarSJTNzi6BEdAimOfdpFctNEQRl3pIkMPJzjFAkusUNolDjGLbFXstH8bTuY7uTboBp5g5J5jyn/180FprQ+qoUfUvtHqYLC0ZqNlylHwIA0H8BWxAbChS7TabK0GgnOFgVkcvBBeUS494ZEoXqFVQZj290EHgb5NiZC/1qb/DcrITubJ+EEvjt4xK2pj6v0nNhDW73wgtarrfwbK99+MIP86vLqwnMnXd79Qe9ZHvLuIQ+Z+wN9iz92N5zg=",id);
                    var ZKDFOzsDpwcZhy_query;
                    ZKDFOzsDpwcZhy_query=qCompressed(1.0,"&1c4$eJx9UE1zgjAU/DOvxzoG+dBjhKDRAjbBznhiEomSqkBDnNZ/X9CZXjrj8b3dt293X+YevF+VuSU+Rw6UuhMXqY9XYXVTR8IKjBLnP5LfWsXRBDJGFzTFb0VENiSNSBru+Awao4+6FucOu+E48bgAVVttb8PVXAD5G7gLJFoQLqHSnW3MYzmFkBGc0yztgaZV5v6SlnMHaIkRR2jkQ3zOfH+7xHyVIFlfi+BbG5W1/fevIc5dqAS+Jnm4LEia03zHFXQnZffVwwAt+b4X2p4y96M7Gme3obKxtrkMnpnLPOazgE2ZYJLtWclfkTOagG3aJ7gLZ3WwTwge9N1Ulrmh34ePcUgGEg9Ad9wKY2M2DeUj4wxi+SnWkyql45UfkEMRNC35seZaKiaHlvCmGBR+AaOSkMo=",id);
                    var vBFzABATciqjRy_query;
                    vBFzABATciqjRy_query=qCompressed(1.0,"&1bb$eJx9UEtzgjAQ/jPbYx2DPPTII2q0gk1oO5yYRKKkKqEQpvXfF2Sml8543P12v9dT4MBrJ5vbzmHIgkK1/CrUqeNG6SrihvtoZ/1H0lstGZpBQsmKxP5LHuE9jiMchxlbgG7USVX80vp2OO2JOcjKKHMbvgIO+G9gNuBohZmAUrVGN+NyDiHFfkqSuAd0LZu7JCkCC0jhI4bQxIXlJXHdt7XPNjskqi73vlUjk7pX/xri3IkKYFuchuscxylJMyahPUtzKEcDpGCHnujtnNjv7amxsj0R2hh9HTxTmzrUpR6dU04FPdCCPSNrMgOj6we4DRd5NA8OHOi7KQ21Q7cPHyRRNh6FYgy2gKX45NtZGZPpxvXwMfd0jX9M0xWSir5J9oH3aT48/gKHAY4R",id);
                    annotation { "Feature Name" : "Extrude 2" }
                    extrude(context, id + "F5SfC2e9JmcTfXk_8", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([IODYdIAwyKyoHf_query, HAEElRPASborZK_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(6 * millimeter), 'expression' : "6 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : true, "startOffsetBound" : StartOffsetType.ENTITY, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([ZKDFOzsDpwcZhy_query]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([vBFzABATciqjRy_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.F5SfC2e9JmcTfXk_8(id));
        features.FpJAbLD6OPw2tXm_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var FyrgqBIyFRwkNu_query;
                    FyrgqBIyFRwkNu_query=qCompressed(1.0,"&2e6$eJx9UNty2jAQ/ZntIwySrzwKWwQ3BZOV05anjGwrQVPARohm+PsIO0nJhOZN2j2XPefbJIC7ozKneSAIhVof5LbUT0dpdbNLpZWMzOnnTXFqlYihyJf5j/xm5Z5qZ7XV6sB8RpORUyuhVkb/VfXUNNtuInvQ6UyeSODvH+EDT2+4o6z1wTbm9CqfIGdFli/commV6ZyzekIhqxkRhAxDmG7yMLyfMfF9Tsrd8SF61kblrRjD/pyqE6pB3PIimT3wRZEVK6Hg8EfZat0fkNWiGnpgZ6tluTHsNo2ntmkxwBAjjHGcVM5rUA8j0NvW6J3FSkSQzZeYLYqUdGlD9M8J/5GwxAprVGJAvKEPG/VocXSuEglS9BjtS0JXFpIRkhiDJBIh/ORY8N+vGoQ6qzE4G46CJwWS4JIW/8eycrVslMy9X2a2j/arsrG22TogkRfCSMp0QC7o/dB7M/k6UgBGP62/zETlFcuPERyEPF5DUXrlMPpu0LM+H96V6MOUJfzj7gVm+t2N",id);
                    var OJQMjXHcCUlxXt_query;
                    OJQMjXHcCUlxXt_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$tHYPblrAKD8FtopR4R5R6R7S7$isStartFR8CbA1S11.9$F5SfC2e9JmcTfXk_8opExtrudeRbS8$CAP_EDGE",id);
                    var KKsouroSWQUJUH_query;
                    KKsouroSWQUJUH_query=qCompressed(1.0,"&1bb$eJx9UEtzgjAQ/jPbYx2DPPTII2q0gk1oO5yYRKKkKqEQpvXfF2Sml8543P12v9dT4MBrJ5vbzmHIgkK1/CrUqeNG6SrihvtoZ/1H0lstGZpBQsmKxP5LHuE9jiMchxlbgG7USVX80vp2OO2JOcjKKHMbvgIO+G9gNuBohZmAUrVGN+NyDiHFfkqSuAd0LZu7JCkCC0jhI4bQxIXlJXHdt7XPNjskqi73vlUjk7pX/xri3IkKYFuchuscxylJMyahPUtzKEcDpGCHnujtnNjv7amxsj0R2hh9HTxTmzrUpR6dU04FPdCCPSNrMgOj6we4DRd5NA8OHOi7KQ21Q7cPHyRRNh6FYgy2gKX45NtZGZPpxvXwMfd0jX9M0xWSir5J9oH3aT48/gKHAY4R",id);
                    annotation { "Feature Name" : "Extrude 3" }
                    extrude(context, id + "FpJAbLD6OPw2tXm_8", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([FyrgqBIyFRwkNu_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(6 * millimeter), 'expression' : "6 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : true, "startOffsetBound" : StartOffsetType.ENTITY, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([OJQMjXHcCUlxXt_query]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([KKsouroSWQUJUH_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FpJAbLD6OPw2tXm_8(id));
        features.FXkKXyVAhY2dCez_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (false)
                {
                    const initialGuessFXkKXyVAhY2dCez_8 = { "iLUdILwgYVhL" : [-0.0836412593126297, 0.0041029192507267, 0.9998461419108005, -0.017541166041276816, 0.0032971350377970785, -1.0], "hG2ttCrAaRp0" : [-0.075036363363266, 0.0041029192507267, 0.9998461419108005, -0.017541166041276816, 0.0032971350377970785, -1.0], "sHAcWSSqLJWX" : [-0.07276432239656136, 0.0041029192507267, 1.0, 0.0, -0.002272040966704636, 0.0024779590332953683], "sHAcWSSqLJWX.endSnap0" : [-0.07028636336326599, 0.005], "xNAFePdLtnOV" : [-0.08614928275346756, 0.0041029192507267, -1.0, 0.0, -0.0025080234408378643, 0.00224197655916214], "xNAFePdLtnOV.endSnap0" : [-0.0883912593126297, 0.005] };
                    {
                    }
                    var LHbsHQByxzOyNG_query;
                    LHbsHQByxzOyNG_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromA2C0M5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$UkO4Vsgr2YPItopR5C7S4$FACER7R8R9CcA1S11.9$FbjaK3hNI0J67Ef_7opExtrudeRcSa$SWEPT_FACEC0M5R1R13R5R14R7R8R9CcA1S11.-18$F5SfC2e9JmcTfXk_8RcR17R5R14R7R8R9CcA1S-1b.7.9$booleanopBooleanRcS5$MERGE",id);
                    annotation { "Feature Name" : "Sketch 3" }
                    var sketch = newSketch(context, id + "FXkKXyVAhY2dCez_8", { "sketchPlane" : qUnion([LHbsHQByxzOyNG_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                    skCircle(sketch, "iLUdILwgYVhL", { "construction" : false, "index" : "1" });
                    skCircle(sketch, "hG2ttCrAaRp0", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "sHAcWSSqLJWX", { "construction" : true, "index" : "1" });
                    skPoint(sketch, "sHAcWSSqLJWX.endSnap0", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "xNAFePdLtnOV", { "construction" : true, "index" : "2" });
                    skPoint(sketch, "xNAFePdLtnOV.endSnap0", { "construction" : false, "index" : "2" });
                    {
                        skConstraint(sketch, "Qk2gE1W5ED69", { "constraintType" : ConstraintType.EQUAL, "index" : "1", "name" : "", "localFirst" : "hG2ttCrAaRp0", "localSecond" : "iLUdILwgYVhL" });
                    }
                    {
                        skConstraint(sketch, "Bv9oWFGkvvcg", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "iLUdILwgYVhL.center", "localSecond" : "hG2ttCrAaRp0.center" });
                    }
                    {
                        skConstraint(sketch, "sHAcWSSqLJWX.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "sHAcWSSqLJWX.start", "localSecond" : "hG2ttCrAaRp0.center" });
                    }
                    {
                        var FdPsxeMhIbvTBS_query;
                        FdPsxeMhIbvTBS_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromA2C0M5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$UkO4Vsgr2YPItopR5C7S4$FACER7R8R9CcA1S11.9$FbjaK3hNI0J67Ef_7opExtrudeRcSa$SWEPT_FACEC0M5R1R13R5R14R7R8R9CcA1S11.-18$F5SfC2e9JmcTfXk_8RcR17R5R14R7R8R9CcA1S-1b.7.9$booleanopBooleanRcS5$MERGE",id);
                        var ItYuKhdPZQgpuL_query;
                        ItYuKhdPZQgpuL_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$UkO4Vsgr2YPItopC0M5R4R5R6R7R8RaRbRcRdSc.4$tHYPblrAKD8FleftR4R5R6R7R8CbA1S11.9$F5SfC2e9JmcTfXk_8opExtrudeRbSa$SWEPT_EDGE",id);
                        skConstraint(sketch, "sHAcWSSqLJWX.endSnap0.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localEntity1" : "sHAcWSSqLJWX.endSnap0", "externalEntity2" : qUnion([qCoEdge(FdPsxeMhIbvTBS_query, ItYuKhdPZQgpuL_query)]) });
                    }
                    {
                        var yTbvhcjKcmKtVV_query;
                        yTbvhcjKcmKtVV_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$UkO4Vsgr2YPItopC0M5R4R5R6R7R8RaRbRcRdSc.4$tHYPblrAKD8FleftR4R5R6R7R8CbA1S11.9$F5SfC2e9JmcTfXk_8opExtrudeRbSa$SWEPT_EDGE",id);
                        skConstraint(sketch, "sHAcWSSqLJWX.endSnap1", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "sHAcWSSqLJWX", "externalSecond" : qUnion([yTbvhcjKcmKtVV_query]) });
                    }
                    {
                        skConstraint(sketch, "sHAcWSSqLJWX.endSnap2", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "name" : "", "localFirst" : "sHAcWSSqLJWX.end", "localSecond" : "sHAcWSSqLJWX.endSnap0" });
                    }
                    {
                        skConstraint(sketch, "xNAFePdLtnOV.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "xNAFePdLtnOV.start", "localSecond" : "iLUdILwgYVhL.center" });
                    }
                    {
                        var XXSSTMQHCydAnE_query;
                        XXSSTMQHCydAnE_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$UkO4Vsgr2YPItopC0M5R4R5R6R7R8RaRbRcRdSc.5$tHYPblrAKD8FrightR4R5R6R7R8CbA1S11.9$F5SfC2e9JmcTfXk_8opExtrudeRbSa$SWEPT_EDGE",id);
                        skConstraint(sketch, "xNAFePdLtnOV.endSnap0.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "2", "name" : "", "localEntity1" : "xNAFePdLtnOV.endSnap0", "externalEntity2" : qUnion([XXSSTMQHCydAnE_query]) });
                    }
                    {
                        var DFmvtdVAVXBVlG_query;
                        DFmvtdVAVXBVlG_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$UkO4Vsgr2YPItopC0M5R4R5R6R7R8RaRbRcRdSc.5$tHYPblrAKD8FrightR4R5R6R7R8CbA1S11.9$F5SfC2e9JmcTfXk_8opExtrudeRbSa$SWEPT_EDGE",id);
                        skConstraint(sketch, "xNAFePdLtnOV.endSnap1", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "2", "name" : "", "localFirst" : "xNAFePdLtnOV", "externalSecond" : qUnion([DFmvtdVAVXBVlG_query]) });
                    }
                    {
                        skConstraint(sketch, "xNAFePdLtnOV.endSnap2", { "constraintType" : ConstraintType.VERTICAL, "index" : "2", "name" : "", "localFirst" : "xNAFePdLtnOV.end", "localSecond" : "xNAFePdLtnOV.endSnap0" });
                    }
                    {
                        skConstraint(sketch, "ttcJZYYoWesj", { "constraintType" : ConstraintType.EQUAL, "index" : "2", "name" : "", "localFirst" : "xNAFePdLtnOV", "localSecond" : "sHAcWSSqLJWX" });
                    }
                    {
                        skConstraint(sketch, "ZWEdgTu1CWbH", { "constraintType" : ConstraintType.LENGTH, "index" : "1", "name" : "", "localFirst" : "xNAFePdLtnOV", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(4.75 * millimeter), 'expression' : "4.75 mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 2.101642335159996, "labelDistance" : 0.002963895443826914 * meter });
                    }
                    skSetInitialGuess(sketch, initialGuessFXkKXyVAhY2dCez_8);
                    skSolve(sketch);
                }
            };
        try(features.FXkKXyVAhY2dCez_8(id));
        features.Fw1a6UVuNIfMqbB_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var kVAUYTEZIpVsuc_query;
                    kVAUYTEZIpVsuc_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FXkKXyVAhY2dCez_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$iLUdILwgYVhLR5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    var cmrOIhLUopJyRI_query;
                    cmrOIhLUopJyRI_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS8$TOPOLOGYS8$entitiesA1A2C0M5Sb$derivedFromC0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FXkKXyVAhY2dCez_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$hG2ttCrAaRp0R5R6R7R8R9CcA1S-d.7$imprintRcS7$IMPRINTD1R5C7S4$FACER7R8R9R12RcR13",id);
                    var QIsQCSPyDtCFrX_query;
                    QIsQCSPyDtCFrX_query=qCompressed(1.0,"&1bb$eJx9UEtzgjAQ/jPbYx2DPPTII2q0gk1oO5yYRKKkKqEQpvXfF2Sml8543P12v9dT4MBrJ5vbzmHIgkK1/CrUqeNG6SrihvtoZ/1H0lstGZpBQsmKxP5LHuE9jiMchxlbgG7USVX80vp2OO2JOcjKKHMbvgIO+G9gNuBohZmAUrVGN+NyDiHFfkqSuAd0LZu7JCkCC0jhI4bQxIXlJXHdt7XPNjskqi73vlUjk7pX/xri3IkKYFuchuscxylJMyahPUtzKEcDpGCHnujtnNjv7amxsj0R2hh9HTxTmzrUpR6dU04FPdCCPSNrMgOj6we4DRd5NA8OHOi7KQ21Q7cPHyRRNh6FYgy2gKX45NtZGZPpxvXwMfd0jX9M0xWSir5J9oH3aT48/gKHAY4R",id);
                    annotation { "Feature Name" : "Extrude 4" }
                    extrude(context, id + "Fw1a6UVuNIfMqbB_8", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([kVAUYTEZIpVsuc_query, cmrOIhLUopJyRI_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(10 * millimeter), 'expression' : "10 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([QIsQCSPyDtCFrX_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.Fw1a6UVuNIfMqbB_8(id));
        features.FWbzhogrg3Ev9tz_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var BVzYPWXkrrzFGR_query;
                    BVzYPWXkrrzFGR_query=qCompressed(1.0,"&46d$eJydkltz2jAQhf/M9hEGyTd4FEYENwXTlZOUp4wvAjQBbGTRDv++sklbMgmUyZul3fPtOSt/GXrw/SD1ceoJQqFQdbrN1OqQGlXuRqlJGZnS95XkWEnRhySex9/iu4X9lDujjJI18xkNe5aWQSG1+imLsS637U16ajo24mEK/O9BuMBHd9xK1qo2pT6+4kPkLInimS2UldTt5KgYUogKRgQhXR/Gm9j3HyZMfJ2SbHd4Dn4pLeNKDGDfpGpBBYh7noSTZz5LomQhJNQv0uTrk4GoELkFPbzE7mO90nQxj7LSmHKLHvoYYB8HYW7HdYpuAGpbabUzmIsAoukco1kyIm1gH90m5D8RZphjgVJ0iNN1wJQV9pplIkGKDqOnNaHL7E3/itSFjVwa9MJA+PDIMeE/XrsItT4GYD1wFDxMRh1yCzTvdkgGZrKYZxvN7kf9sW0i+RkUSYHkXHq6dJAs/2S1+M/F8UCr1dp8PPI2yLLboQQ+JCyvm6b0kulrw8gAGuX/HNNLkGbhzSumsfOkJ/tgv/iMd4e89Y6OezbcVt3e7e/oXcSeM7OmeiE2uukFy177r7owZiF/W/sNCnlF6g==",id);
                    var dLMtimUnqAqfPF_query;
                    dLMtimUnqAqfPF_query=qCompressed(1.0,"&5c8$eJydVF9zojAQ/zK5Rx0TAugjQqxcT/E2tHc8dYBEzVRFMd6N3/4C2I5exTp9Anazv3+b4dvQRj8PsjxObI4JEmqfrjO1OKRaFZsg1amHJ+RjJz5uJe+jOJpFP6KHxLzKjVZayb1necTvTWzoVZOAgYDlOU2NZ0jIUv2RYlQW67qSNoPHCnCYIvb+wSliwQMzI0u110V5PFH6wLw4jKamUWxlWasJxZCgUHiYY9x10GgVOc7T2OPfJzjbHF7cv6qU0ZYP0K5yWgMJxB9Z7I9f2DQO44RLtH+VOl82AkLBcwP09BrR5/2iJMkszAqtizXY4IALfRj4uaHriK6L1Hpbqo2GnLsonMwgnMYBrg07QOso3ocggxwESN7BVtdCuthexERO0VHPVPo3RilaybkG23e5g54ZxOz36RQmRscAGQ0MOPPjoIPvAc27HZwhPU5m2ar0HoP+yBzC+RkoYAH4fLQpWoDnb14N/Nfs2KhUi6W+TnkfyLzbIRhdRZjfFk1Im+hbZHiAqsnPFJM2kCrwaotpZP0qxzt3l3xFu4UvtYNFz8hNl/bu36PdCnuOmVXdFttA0xbJdn1XKRp5PrvOe/nDoDfuFBBaZwCW9emN/H+54PQqmaQ9AqDzNwDjuAnwI4Ep2uJ+IxWSSa6N0W2edr/x5chG3hWGU4zDKEgue/8AEMaetA==",id);
                    annotation { "Feature Name" : "Mate connector 1" }
                    mateConnector(context, id + "FWbzhogrg3Ev9tz_8", { "originType" : OriginCreationType.ON_ENTITY, "originQuery" : qUnion([BVzYPWXkrrzFGR_query]), "entityInferenceType" : EntityInferenceType.CENTROID, "secondaryOriginQuery" : qUnion([]), "originAdditionalQuery" : qUnion([]), "realign" : false, "primaryAxisQuery" : qUnion([]), "secondaryAxisQuery" : qUnion([]), "transform" : false, "translationX" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "translationY" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "translationZ" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "rotationType" : RotationType.ABOUT_Z, "rotation" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "allowOwnerEntity" : true, "requireOwnerPart" : true, "ownerPart" : qUnion([dLMtimUnqAqfPF_query]), "specifyNormal" : false, "nx" : { 'value' : try(0), 'expression' : "0" }.value, "ny" : { 'value' : try(0), 'expression' : "0" }.value, "nz" : { 'value' : try(0), 'expression' : "0" }.value, "flipPrimary" : false, "secondaryAxisType" : MateConnectorAxisType.PLUS_X, "isForSubFeature" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FWbzhogrg3Ev9tz_8(id));
        features.Fc6UOalBO0FOIzD_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var ChbndSutDYEarh_query;
                    ChbndSutDYEarh_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FiGsjAS4K608afc_0wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$FGxrECzZ95jqR4C6S4$FACER6R7R8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$SWEPT_FACE",id);
                    var UlPuckgzaTQzYf_query;
                    UlPuckgzaTQzYf_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    annotation { "Feature Name" : "Mate connector 2" }
                    mateConnector(context, id + "Fc6UOalBO0FOIzD_8", { "originType" : OriginCreationType.ON_ENTITY, "originQuery" : qUnion([ChbndSutDYEarh_query]), "entityInferenceType" : EntityInferenceType.CENTROID, "secondaryOriginQuery" : qUnion([]), "originAdditionalQuery" : qUnion([]), "realign" : false, "primaryAxisQuery" : qUnion([]), "secondaryAxisQuery" : qUnion([]), "transform" : false, "translationX" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "translationY" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "translationZ" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "rotationType" : RotationType.ABOUT_Z, "rotation" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "allowOwnerEntity" : true, "requireOwnerPart" : true, "ownerPart" : qUnion([UlPuckgzaTQzYf_query]), "specifyNormal" : false, "nx" : { 'value' : try(0), 'expression' : "0" }.value, "ny" : { 'value' : try(0), 'expression' : "0" }.value, "nz" : { 'value' : try(0), 'expression' : "0" }.value, "flipPrimary" : false, "secondaryAxisType" : MateConnectorAxisType.PLUS_X, "isForSubFeature" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.Fc6UOalBO0FOIzD_8(id));
        features.FjRMvliGQTdxydk_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var FYGNezOKJLAWUD_query;
                    FYGNezOKJLAWUD_query=qCompressed(1.0,"&1bb$eJx9UEtzgjAQ/jPbYx2DPPTII2q0gk1oO5yYRKKkKqEQpvXfF2Sml8543P12v9dT4MBrJ5vbzmHIgkK1/CrUqeNG6SrihvtoZ/1H0lstGZpBQsmKxP5LHuE9jiMchxlbgG7USVX80vp2OO2JOcjKKHMbvgIO+G9gNuBohZmAUrVGN+NyDiHFfkqSuAd0LZu7JCkCC0jhI4bQxIXlJXHdt7XPNjskqi73vlUjk7pX/xri3IkKYFuchuscxylJMyahPUtzKEcDpGCHnujtnNjv7amxsj0R2hh9HTxTmzrUpR6dU04FPdCCPSNrMgOj6we4DRd5NA8OHOi7KQ21Q7cPHyRRNh6FYgy2gKX45NtZGZPpxvXwMfd0jX9M0xWSir5J9oH3aT48/gKHAY4R",id);
                    var pnwmKVIWBiIPTh_query;
                    pnwmKVIWBiIPTh_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6$UkO4Vsgr2YPIbottomC0M5R4R5R6R7R8RaRbRcRdS-12.5$rightR4R5R6R7R8CbA1S11.9$FbjaK3hNI0J67Ef_7opExtrudeRbSa$SWEPT_EDGE",id);
                    annotation { "Feature Name" : "Transform 3" }
                    transform(context, id + "FjRMvliGQTdxydk_8", { "entities" : qUnion([FYGNezOKJLAWUD_query]), "transformType" : TransformType.ROTATION, "oppositeDirectionEntity" : false, "transformLine" : qUnion([]), "transformAxis" : qUnion([pnwmKVIWBiIPTh_query]), "transformDirection" : qUnion([]), "distance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "uniform" : true, "scale" : { 'value' : try(1), 'expression' : "1" }.value, "scaleX" : { 'value' : try(1), 'expression' : "1" }.value, "scaleY" : { 'value' : try(1), 'expression' : "1" }.value, "scaleZ" : { 'value' : try(1), 'expression' : "1" }.value, "baseConnector" : qUnion([]), "destinationConnector" : qUnion([]), "oppositeDirectionMateAxis" : false, "secondaryAxisType" : MateConnectorAxisType.PLUS_X, "angle" : { 'value' : try(90 * degree), 'expression' : "90 deg" }.value, "oppositeDirection" : true, "dx" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "dy" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "dz" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "scalePoint" : qUnion([]), "makeCopy" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FjRMvliGQTdxydk_8(id));
        features.FzObIAnJ6LDAxgx_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var VshQAkfiaJFEtm_query;
                    VshQAkfiaJFEtm_query=qCompressed(1.0,"&1bb$eJx9UEtzgjAQ/jPbYx2DPPTII2q0gk1oO5yYRKKkKqEQpvXfF2Sml8543P12v9dT4MBrJ5vbzmHIgkK1/CrUqeNG6SrihvtoZ/1H0lstGZpBQsmKxP5LHuE9jiMchxlbgG7USVX80vp2OO2JOcjKKHMbvgIO+G9gNuBohZmAUrVGN+NyDiHFfkqSuAd0LZu7JCkCC0jhI4bQxIXlJXHdt7XPNjskqi73vlUjk7pX/xri3IkKYFuchuscxylJMyahPUtzKEcDpGCHnujtnNjv7amxsj0R2hh9HTxTmzrUpR6dU04FPdCCPSNrMgOj6we4DRd5NA8OHOi7KQ21Q7cPHyRRNh6FYgy2gKX45NtZGZPpxvXwMfd0jX9M0xWSir5J9oH3aT48/gKHAY4R",id);
                    var ddjRbqUAgZkYaQ_query;
                    ddjRbqUAgZkYaQ_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.f$FWbzhogrg3Ev9tz_8mateConnectorOpS9$queryTypeS5$DUMMY",id);
                    var nJYZprovbLFDvQ_query;
                    nJYZprovbLFDvQ_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.f$Fc6UOalBO0FOIzD_8mateConnectorOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Transform 1" }
                    transform(context, id + "FzObIAnJ6LDAxgx_8", { "entities" : qUnion([VshQAkfiaJFEtm_query]), "transformType" : TransformType.TRANSFORM_MATE_CONNECTORS, "oppositeDirectionEntity" : false, "transformLine" : qUnion([]), "transformAxis" : qUnion([]), "transformDirection" : qUnion([]), "distance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "uniform" : true, "scale" : { 'value' : try(1), 'expression' : "1" }.value, "scaleX" : { 'value' : try(1), 'expression' : "1" }.value, "scaleY" : { 'value' : try(1), 'expression' : "1" }.value, "scaleZ" : { 'value' : try(1), 'expression' : "1" }.value, "baseConnector" : qUnion([ddjRbqUAgZkYaQ_query]), "destinationConnector" : qUnion([nJYZprovbLFDvQ_query]), "oppositeDirectionMateAxis" : false, "secondaryAxisType" : MateConnectorAxisType.PLUS_X, "angle" : { 'value' : try(30 * degree), 'expression' : "30 deg" }.value, "oppositeDirection" : false, "dx" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "dy" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "dz" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "scalePoint" : qUnion([]), "makeCopy" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FzObIAnJ6LDAxgx_8(id));
        features.FSHhGDsH8XioFWW_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var uBmdPCOQuFpTJK_query;
                    uBmdPCOQuFpTJK_query=qCompressed(1.0,"&1bb$eJx9UEtzgjAQ/jPbYx2DPPTII2q0gk1oO5yYRKKkKqEQpvXfF2Sml8543P12v9dT4MBrJ5vbzmHIgkK1/CrUqeNG6SrihvtoZ/1H0lstGZpBQsmKxP5LHuE9jiMchxlbgG7USVX80vp2OO2JOcjKKHMbvgIO+G9gNuBohZmAUrVGN+NyDiHFfkqSuAd0LZu7JCkCC0jhI4bQxIXlJXHdt7XPNjskqi73vlUjk7pX/xri3IkKYFuchuscxylJMyahPUtzKEcDpGCHnujtnNjv7amxsj0R2hh9HTxTmzrUpR6dU04FPdCCPSNrMgOj6we4DRd5NA8OHOi7KQ21Q7cPHyRRNh6FYgy2gKX45NtZGZPpxvXwMfd0jX9M0xWSir5J9oH3aT48/gKHAY4R",id);
                    annotation { "Feature Name" : "Transform 2" }
                    transform(context, id + "FSHhGDsH8XioFWW_8", { "entities" : qUnion([uBmdPCOQuFpTJK_query]), "transformType" : TransformType.TRANSLATION_3D, "oppositeDirectionEntity" : false, "transformLine" : qUnion([]), "transformAxis" : qUnion([]), "transformDirection" : qUnion([]), "distance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "uniform" : true, "scale" : { 'value' : try(1), 'expression' : "1" }.value, "scaleX" : { 'value' : try(1), 'expression' : "1" }.value, "scaleY" : { 'value' : try(1), 'expression' : "1" }.value, "scaleZ" : { 'value' : try(1), 'expression' : "1" }.value, "baseConnector" : qUnion([]), "destinationConnector" : qUnion([]), "oppositeDirectionMateAxis" : false, "secondaryAxisType" : MateConnectorAxisType.PLUS_X, "angle" : { 'value' : try(30 * degree), 'expression' : "30 deg" }.value, "oppositeDirection" : false, "dx" : { 'value' : try(55 * millimeter), 'expression' : "55 mm" }.value, "dy" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "dz" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "scalePoint" : qUnion([]), "makeCopy" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FSHhGDsH8XioFWW_8(id));
        features.FDazl34QFPYVJeX_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (false)
                {
                    const initialGuessFDazl34QFPYVJeX_8 = { "opeAQwTIDScf" : [-0.010456701264176544, 0.05103649137547194, -0.323444480240594, 0.9462471496400356, -0.0035869861461819835, 0.004251755302738112], "FcOxZKMCEkNz" : [0.008919118574653998, 0.062152780902732886, 0.9462471496400356, 0.3234444802405941, -0.02192981678278113, -0.016929816782781132], "MWlIpvpkdwqn" : [0.02739318472142487, 0.06397427058509574, 0.3234444802405939, -0.9462471496400358, -0.004251755302738067, 0.0035869861461820312], "NAmE3jNYXyyo" : [0.0065313257045007045, 0.05305255811632366, -0.9462471496400358, -0.3234444802405939, -0.02327304224375598, -0.018273042243755967], "EUompQMJkT6h" : [-0.005832973473137503, 0.05296823173645483, 0.32344448024059413, -0.9462471496400356, -0.0039193707244600555, 0.003919370724460048], "enJWn5bX1uDk" : [0.02255444101606357, 0.06267156614367264, 0.3234444802405939, -0.9462471496400358, -0.0039193707244600615, 0.003919370724460041], "K6ocJeBfLNUu" : [0.011284679662719585, 0.058219582373920664, -0.9907864065506717, -0.13543373506777004, -0.01742928224914455, 0.023331555174821824], "MhRtWveCqjsJ" : [0.008360733771463031, 0.05781989894006374], "8k5EBQGG0FKG" : [0.008360733771463031, 0.05781989894006374], "oyfc9u6X57rZ.trimOffspring" : [0.0065313257045007045, 0.05305255811632366, -0.9462471496400358, -0.3234444802405939, 0.011726957756244034, 0.01672695775624404], "E3p65GZvKS7x.trimOffspring" : [0.008919118574653998, 0.062152780902732886, 0.9462471496400356, 0.323444480240594, 0.013070183217218864, 0.01807018321721888] };
                    {
                    }
                    var WYBaouqRQEKxmt_query;
                    WYBaouqRQEKxmt_query=qCompressed(1.0,"&212$eJx1kFtzgjAQhf9M+toBRS6PEAJiBW3C2OILEySDgcolBC399RWd6UuHx939ds/Z8+KswPvAxBjqRF2AnPf0kvFioJI3tUsltdVw8X8Sjy0j6hLscOAHkb1NXbRHkYsimBALNIIXvKZfva1DJVwRClgtuRynLYcC9FcQDSDXRyQDZ97LRjybJoAY2XGwi+6DpmXiIRnkzgIEua0SVX3VgRd1or/6Bz9UjlXmpssbF2zX3tW76Z3HoRyQNxTDdYqiOIgTwkBfMXk6Pw0EOTkBCCOz83yWXzpv8oo1vMI6NrCJKc7wCU/Q7dCRa1x6tVCsWWipqUFxS8p23P7MQnlVtsqhdpp+/J6F2IdSnrHNEJPJvNyRXkbqsM/MW2MN6vcoPRuiiSMG4D2RVEgPmzB7JmYBbyh6qq4tveLGZmOky6ZF31IMOcPZlLm9T6cLv8tFq70=",id);
                    annotation { "Feature Name" : "PSU mounts" }
                    var sketch = newSketch(context, id + "FDazl34QFPYVJeX_8", { "sketchPlane" : qUnion([WYBaouqRQEKxmt_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                    skLineSegment(sketch, "opeAQwTIDScf", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "FcOxZKMCEkNz", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "MWlIpvpkdwqn", { "construction" : false, "index" : "3" });
                    skLineSegment(sketch, "NAmE3jNYXyyo", { "construction" : false, "index" : "4" });
                    skLineSegment(sketch, "EUompQMJkT6h", { "construction" : false, "index" : "5" });
                    skLineSegment(sketch, "enJWn5bX1uDk", { "construction" : false, "index" : "6" });
                    skLineSegment(sketch, "K6ocJeBfLNUu", { "construction" : true, "index" : "11" });
                    skPoint(sketch, "MhRtWveCqjsJ", { "construction" : false, "index" : "1" });
                    skPoint(sketch, "8k5EBQGG0FKG", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "oyfc9u6X57rZ.trimOffspring", { "construction" : false, "index" : "12" });
                    skLineSegment(sketch, "E3p65GZvKS7x.trimOffspring", { "construction" : false, "index" : "13" });
                    {
                        var LVbmDQhVKkVtHu_query;
                        LVbmDQhVKkVtHu_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$341IgwYjpyLzR4R5R6R7S7$isStartFR8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "opeAQwTIDScf.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "opeAQwTIDScf.start", "externalSecond" : qUnion([LVbmDQhVKkVtHu_query]) });
                    }
                    {
                        var bsHyOOnEiceqJT_query;
                        bsHyOOnEiceqJT_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$eW0jhRAeEetYR4R5R6R7S7$isStartFR8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "opeAQwTIDScf.endSnap0", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "1", "name" : "", "localFirst" : "opeAQwTIDScf", "externalSecond" : qUnion([bsHyOOnEiceqJT_query]) });
                    }
                    {
                        skConstraint(sketch, "FcOxZKMCEkNz.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "FcOxZKMCEkNz.start", "localSecond" : "opeAQwTIDScf.end" });
                    }
                    {
                        skConstraint(sketch, "FcOxZKMCEkNz.endSnap0", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "2", "name" : "", "localFirst" : "FcOxZKMCEkNz", "localSecond" : "opeAQwTIDScf" });
                    }
                    {
                        skConstraint(sketch, "MWlIpvpkdwqn.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "MWlIpvpkdwqn.start", "localSecond" : "E3p65GZvKS7x.trimOffspring.end" });
                    }
                    {
                        var eYfGKHZaFDBamc_query;
                        eYfGKHZaFDBamc_query=qCompressed(1.0,"&212$eJx1kFtzgjAQhf9M+toBRS6PEAJiBW3C2OILEySDgcolBC399RWd6UuHx939ds/Z8+KswPvAxBjqRF2AnPf0kvFioJI3tUsltdVw8X8Sjy0j6hLscOAHkb1NXbRHkYsimBALNIIXvKZfva1DJVwRClgtuRynLYcC9FcQDSDXRyQDZ97LRjybJoAY2XGwi+6DpmXiIRnkzgIEua0SVX3VgRd1or/6Bz9UjlXmpssbF2zX3tW76Z3HoRyQNxTDdYqiOIgTwkBfMXk6Pw0EOTkBCCOz83yWXzpv8oo1vMI6NrCJKc7wCU/Q7dCRa1x6tVCsWWipqUFxS8p23P7MQnlVtsqhdpp+/J6F2IdSnrHNEJPJvNyRXkbqsM/MW2MN6vcoPRuiiSMG4D2RVEgPmzB7JmYBbyh6qq4tveLGZmOky6ZF31IMOcPZlLm9T6cLv8tFq70=",id);
                        var xPLlgVEkoMmwrg_query;
                        xPLlgVEkoMmwrg_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$341IgwYjpyLzR4R5R6R7S7$isStartFR8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "MWlIpvpkdwqn.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "4", "name" : "", "localFirst" : "MWlIpvpkdwqn.end", "externalSecond" : qUnion([qCoEdge(eYfGKHZaFDBamc_query, xPLlgVEkoMmwrg_query)]) });
                    }
                    {
                        var vxVwuradYEhMMZ_query;
                        vxVwuradYEhMMZ_query=qCompressed(1.0,"&212$eJx1kFtzgjAQhf9M+toBRS6PEAJiBW3C2OILEySDgcolBC399RWd6UuHx939ds/Z8+KswPvAxBjqRF2AnPf0kvFioJI3tUsltdVw8X8Sjy0j6hLscOAHkb1NXbRHkYsimBALNIIXvKZfva1DJVwRClgtuRynLYcC9FcQDSDXRyQDZ97LRjybJoAY2XGwi+6DpmXiIRnkzgIEua0SVX3VgRd1or/6Bz9UjlXmpssbF2zX3tW76Z3HoRyQNxTDdYqiOIgTwkBfMXk6Pw0EOTkBCCOz83yWXzpv8oo1vMI6NrCJKc7wCU/Q7dCRa1x6tVCsWWipqUFxS8p23P7MQnlVtsqhdpp+/J6F2IdSnrHNEJPJvNyRXkbqsM/MW2MN6vcoPRuiiSMG4D2RVEgPmzB7JmYBbyh6qq4tveLGZmOky6ZF31IMOcPZlLm9T6cLv8tFq70=",id);
                        var NhRDmCdlIdtKSV_query;
                        NhRDmCdlIdtKSV_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$341IgwYjpyLzR4R5R6R7S7$isStartFR8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "MWlIpvpkdwqn.endSnap1", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "3", "name" : "", "localFirst" : "MWlIpvpkdwqn", "externalSecond" : qUnion([qCoEdge(vxVwuradYEhMMZ_query, NhRDmCdlIdtKSV_query)]) });
                    }
                    {
                        skConstraint(sketch, "NAmE3jNYXyyo.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "5", "name" : "", "localFirst" : "NAmE3jNYXyyo.start", "localSecond" : "MWlIpvpkdwqn.end" });
                    }
                    {
                        skConstraint(sketch, "NAmE3jNYXyyo.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "6", "name" : "", "localFirst" : "oyfc9u6X57rZ.trimOffspring.end", "localSecond" : "opeAQwTIDScf.start" });
                    }
                    {
                        var tbokuvmoZzlSzM_query;
                        tbokuvmoZzlSzM_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$341IgwYjpyLzR4R5R6R7S7$isStartFR8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "EUompQMJkT6h.endSnap0", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "4", "name" : "", "localFirst" : "EUompQMJkT6h", "externalSecond" : qUnion([tbokuvmoZzlSzM_query]) });
                    }
                    {
                        skConstraint(sketch, "enJWn5bX1uDk.endSnap0", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "5", "name" : "", "localFirst" : "enJWn5bX1uDk", "localSecond" : "FcOxZKMCEkNz" });
                    }
                    {
                        var DFRSreQdDhtGqc_query;
                        DFRSreQdDhtGqc_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$341IgwYjpyLzR4R5R6R7S7$isStartFR8CbA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "enJWn5bX1uDk.endSnap1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "10", "name" : "", "localFirst" : "enJWn5bX1uDk.end", "externalSecond" : qUnion([DFRSreQdDhtGqc_query]) });
                    }
                    {
                        skConstraint(sketch, "N2PxNYvf5FSV", { "constraintType" : ConstraintType.DISTANCE, "index" : "4", "name" : "", "localFirst" : "enJWn5bX1uDk", "localSecond" : "MWlIpvpkdwqn", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "halfSpace0" : DimensionHalfSpace.LEFT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : -1.1225629152439929, "labelDistance" : -0.011253008001983486 * meter });
                    }
                    {
                        skConstraint(sketch, "xvLt3R4n5wwy", { "constraintType" : ConstraintType.DISTANCE, "index" : "5", "name" : "", "localFirst" : "EUompQMJkT6h", "localSecond" : "opeAQwTIDScf", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : -0.9048329741709663, "labelDistance" : -0.01055539254941247 * meter });
                    }
                    {
                        skConstraint(sketch, "K6ocJeBfLNUu.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "15", "name" : "", "localFirst" : "K6ocJeBfLNUu.start", "localSecond" : "MWlIpvpkdwqn.end" });
                    }
                    {
                        skConstraint(sketch, "K6ocJeBfLNUu.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "16", "name" : "", "localFirst" : "K6ocJeBfLNUu.end", "localSecond" : "opeAQwTIDScf.end" });
                    }
                    {
                        skConstraint(sketch, "MhRtWveCqjsJ.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localEntity1" : "MhRtWveCqjsJ", "localEntity2" : "K6ocJeBfLNUu" });
                    }
                    {
                        skConstraint(sketch, "pJVSKCTQOlQf", { "constraintType" : ConstraintType.COINCIDENT, "index" : "20", "name" : "", "localFirst" : "8k5EBQGG0FKG", "localSecond" : "MhRtWveCqjsJ" });
                    }
                    {
                        skConstraint(sketch, "oyfc9u6X57rZ.coincCurves", { "constraintType" : ConstraintType.COINCIDENT, "index" : "21", "name" : "", "localFirst" : "NAmE3jNYXyyo", "localSecond" : "oyfc9u6X57rZ.trimOffspring", "sketchToolType" : SketchToolType.TRIM });
                    }
                    {
                        skConstraint(sketch, "oyfc9u6X57rZ.coinc1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "22", "name" : "", "localFirst" : "NAmE3jNYXyyo.end", "localSecond" : "enJWn5bX1uDk.end", "sketchToolType" : SketchToolType.TRIM });
                    }
                    {
                        skConstraint(sketch, "oyfc9u6X57rZ.coinc2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "23", "name" : "", "localFirst" : "oyfc9u6X57rZ.trimOffspring.start", "localSecond" : "EUompQMJkT6h.end", "sketchToolType" : SketchToolType.TRIM });
                    }
                    {
                        skConstraint(sketch, "E3p65GZvKS7x.coincCurves", { "constraintType" : ConstraintType.COINCIDENT, "index" : "24", "name" : "", "localFirst" : "FcOxZKMCEkNz", "localSecond" : "E3p65GZvKS7x.trimOffspring", "sketchToolType" : SketchToolType.TRIM });
                    }
                    {
                        skConstraint(sketch, "E3p65GZvKS7x.coinc1", { "constraintType" : ConstraintType.COINCIDENT, "index" : "25", "name" : "", "localFirst" : "FcOxZKMCEkNz.end", "localSecond" : "EUompQMJkT6h.start", "sketchToolType" : SketchToolType.TRIM });
                    }
                    {
                        skConstraint(sketch, "E3p65GZvKS7x.coinc2", { "constraintType" : ConstraintType.COINCIDENT, "index" : "26", "name" : "", "localFirst" : "E3p65GZvKS7x.trimOffspring.start", "localSecond" : "enJWn5bX1uDk.start", "sketchToolType" : SketchToolType.TRIM });
                    }
                    {
                        skConstraint(sketch, "kaQEWOJ7L4wP", { "constraintType" : ConstraintType.DISTANCE, "index" : "6", "name" : "", "localFirst" : "opeAQwTIDScf", "localSecond" : "MWlIpvpkdwqn", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(40 * millimeter), 'expression' : "40 mm" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : 0.7124181061322059, "labelDistance" : 0.022892485643508473 * meter });
                    }
                    skSetInitialGuess(sketch, initialGuessFDazl34QFPYVJeX_8);
                    skSolve(sketch);
                }
            };
        try(features.FDazl34QFPYVJeX_8(id));
        features.FiC6SElq5R48HuP_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var cyeVZKOrbOToWz_query;
                    cyeVZKOrbOToWz_query=qCompressed(1.0,"&385$eJx9Ul13ojAQ/TPZR3sIn/oYIVhsAZ1wbO0LByGrWT/AgFr76xu0tnW37luYuXfuvTP86ltovOPyGFoM66gQdbaeifkua0S58bImIzjU/+0kx4qzLkriUfwYD6bqyTeNaASviUl0VwttNkMFl2LPC1+Wa1WxWHYGHVtyP0P084OZiHoDqigLUTelPH6Md4GSJIgj1SgrLk/KQdHXUVAQzDC+s5HvZW8rwxz7o+lkyJ/T7kFIHlesh7ZtqtOgArEHmrj3KY2SIJkyjuolb/LF2UBQsLwdT8aHJPBY/hu0NjNg0MEg+imNBSoVYO30tMAGB7rQgxnkUABXfD+PX18eQpcuozewXIfZaEIhoc9npJsrv53izkFiXUmxaSBXDoMoocCom3j4S6Xd3cUBwwaKIRgEEXlMPTqikUcjd6qopRRzsclWNcHXnk5KajMdjvxoK+v9YDIItZflzEuNT7f8SfuzAMIpb6YXKlPeatZksvG/pvSQv5vXGb7v2UvhDIdOapQVfW3kruAqgroQGaXt6dRu1CBsfiwG20oLO14Hf9tWW1QqQTgClRz02SU0YP0vGBjapW+DeXPr4dMqqPbVsjhsN7evpgr2D+a+GVAovXsDhXv/9dYSr5RBV4j8B047SP0YJvKJS69774dADWI=",id);
                    var eiGIWOhJyhJVqy_query;
                    eiGIWOhJyhJVqy_query=qCompressed(1.0,"&3e2$eJx1Udt2ojAU/ZnMo10m4VIfUwiWTkV7wmplXlwIqY03ELCWfv0EvIx1dC0eQvbl7H3y68FEL1tZ1ANTYIJSVcarqZpt40plazeuYoYH5H8krHMp7lE4HA2fh/1IH+W6UpWSJTMYcboDS0xRKgv1KVOvyFb6xhTxnlQ34ocY8dOPMBB3+1xLPlRZZUV9sHeAs9AfBhrIclm0k/30gSA/ZVhgfGchz42/l9R48UbR65McT+53qpDDXPTQpmnVGqVI/Oah8zjhQeiHkZCoXMgq+dgH8FORNPbsZRf6rkjeodt0BgwEKCNtGxMMRptWR0xgiobg9/2APU9cPuKBywMn0mOzQs3UOl6WDLdCEyyw4R56TrLP3JHICzZF+dl/7Q+6fxZTd0IhgRSkzkEN7M920Tyvn7+PUmEjVYoqLirvn0sPedtZGePHnrVQ9tOTPaFZzr+qYptKSJrdsdGkWSrg7s8cMD1NC9iK03kQjes6A9OxhYVeOYR8fJa4k97p+au8UOtKG/eQH4QcBHdCt4NPyyHnywGsP3LZH7BxGizfuvMPYJLLKjoxcOw1rESzcKpja4CQg5Y0WmK6+MyvudO78Qcj0JmA2IcUxs2+g7eln3/mi3S3Wd96ZcASaAzk2nigZ42BtMQrLGJfpARqHeNp6d77Bm41uLwMB7TbEoC+6wxX1e37GchjDv+J/QXD8ydA",id);
                    var zGdPRmRcIXomEf_query;
                    zGdPRmRcIXomEf_query=qCompressed(1.0,"&3f1$eJx1Udt2ojAU/ZnMY7tMuNXHFILFqaAnTEf6wkKImlqFBmzHfv0ErI51dC0eQvbl7H3y495Ck61Qu5HFMUGFrLP1TC62WSPLjZc1GcUj8j8S7yrB71AcjaPHaJDoo9g0spGipiYlbm9k8xkqhJLvovBVudY3Fs/2pF0rvs8QO/5wEzFvwLRkKeumVLsvexcYjYMo1EBZCdVNDop7goKCYo7xrY18L/t8NcyJP06ehmKa3n1IJaKK99Fb26ozKhD/yWL3IWVhHMQJF6heiSZf7gMEBc9bezr5iAOP53PotZ0BAwGDkq6NBSY12lYHjGMDRRAMgpA+ph4bs9BjoZvosaWSC7nJXmuKO6EFNjhwB30332e+EcgP31T9PngajHrPq5mXGpBDAULnMEwcLD6Sl2r3+HmQcgfJmjeZavx/Ln3kbxd1hh/69ko6w6GTGmXF/jRqWwjI293RcdouFXDvew6YHabdFqjczfP+1p5ajnpulFxH83ldKblZgOU63EZPDGI2PSlwU9zqOOuW0+g5fRSEMQPO3Ni7wcddkdNdAdYfOV8HYPPYWvzuvSyBCiaa5MjAmd+ycs3ChW6hAUK+tKTVEsvDJ37tnV5VMBqDzgTE+UphXquP2K9yXU1Gw1VsL689OmABRgbk0ngwThoD6YgXWMQ5SwmGfYinpXvvK7jd4uI8HBi9jgDGXGe4qO7ez0Q+ddl37C/+Yyx6",id);
                    var xiAlRpClDvqEOO_query;
                    xiAlRpClDvqEOO_query=qCompressed(1.0,"&399$eJx1Ult3ojAQ/jPZRz2Eqz4iBIotYCccL33hcEk1qwIFtOv++g2o69q1b0lm5rtNfkw09Hpg9cnXKJZRzptkn/L1IWl5WdhJm5jYl/+vRKeK0RGKwln4ErorcWRFy1vOGlM1ZUvydZqinNX8yHKnLvfiRaPJuenUDU8SRP5eqIqI7RIxsuFNW9anC7wFxIy8MBCFsmJ1z+zlExl5uYkpxkMdOXbye6eor85sNZ+yZTz65DULKzpGH52rHihH9JlE1lNMgsiLVpShZsvabHMW4OU0Q/5i51XHapt/fhQgdZ4BgwyKKfduNBCuAEv9UQMdDBjBGFLIIAdGs2GOiFLpmvt2fKbGr7bm+/D9valqXqxBswyqozmBiCzPg1Ym5A/yoYH4vutpIROCvSAiQIkV2QN8Y+2yvCqiWEEheK4XmC+xTWYksElgrcRsWfM1L5JdY+J7jT2VSGrAkBN81M3Rnbu+9LZN7Vi5qkdsIf3cgMkIa1fXUSrENbRN6ta5oYyRc1g3CX4a61tuTKdGrJQVEX4PORMexMbMWdytUmQlgLB6CQrrggsbNv4nvO5NkHj+DIRzwOOLV/W7kMXvmS4KLV3ig739dkmKClh+wH0lOHfJo67xQZecfpEIiiQer6Nn7K/1m/YO+E4ZyFknSvSOHwL3v0NFjmmR+9ofc48Tqw==",id);
                    var jePRPWqHQjinps_query;
                    jePRPWqHQjinps_query=qCompressed(1.0,"&1c8$eJx1UE1TgzAQ/TPr1TFIKRwhBGQsFJNMnXphAsmUTBVoCFr+vaWd8eL0uLtv39dDtIK3SZk59xhyQOpRfNX6MAmr+y4WVoQod/5f+Dwohp5hS7M0K8JNFZOSFDEp8J4F0Bt90J34HEMXP+UrJkB1Vtt5+YoEkL+BuUDilLAaWj3a3tyWPmBKQp5ti8uhH5S5SmYyciCTIWIIPXqQ9PPR0SiX77wbNm3l/GijtsNF/bTEuRJJYK+E45eKFDzje6ZgPCrbtDcDmWQNIG+e9S4azyzAi1fq0hX16Jr6VNCaNnQB5bSOOpWuLVXBXVA3qO9Wp7tSEnQXdJoSMrkfoqnjlLrYuxSQhJgsOLYGPTIrjOXUx/UtZwBJ6ru7aZf6qi15Zyq3H8jZmkkqWi9NhWW1MPwCQjqUlw==",id);
                    var oXtiQcarLBQZAO_query;
                    oXtiQcarLBQZAO_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    annotation { "Feature Name" : "Extrude 5" }
                    extrude(context, id + "FiC6SElq5R48HuP_8", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([cyeVZKOrbOToWz_query, eiGIWOhJyhJVqy_query, zGdPRmRcIXomEf_query, xiAlRpClDvqEOO_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.UP_TO_SURFACE, "oppositeDirection" : true, "depth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "endBoundEntityFace" : qUnion([jePRPWqHQjinps_query]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : true, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(24 * millimeter), 'expression' : "24 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([oXtiQcarLBQZAO_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FiC6SElq5R48HuP_8(id));
        features.FT56TNE8MwTVFtD_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFT56TNE8MwTVFtD_8 = { "0nGY6JnddUDU" : [-0.0012936238881067303, 0.05918826405800062], "KkQh5kBb7QGL" : [-0.0012936238881067303, 0.05918826405800062], "9jFNW5HP7Iio" : [-0.008005351485800909, 0.07452211494335585, -0.9462471496400359, 0.3234444802405938, -0.024059653865260894, 9.403461347391075E-4], "dgcwjO6s0Kf1" : [-0.004501972031418136, 0.0876786509720149, -0.3234444802405938, -0.9462471496400358, 0.013582483462963474, 0.025582483462963466], "Vw7ijmdnV65W" : [-0.010472547950734566, 0.0626837713076477, 0.9462471496400358, -0.32344448024059386, -0.002434815416354829, 0.022565184583645176], "tOZDGWnr11kI" : [0.019292671285074982, 0.07999762150068475, 0.32344448024059375, 0.9462471496400359, -0.02601057725942964, -0.014010577259429637] };
                    {
                    }
                    var qSpNADYzbvqonE_query;
                    qSpNADYzbvqonE_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S5.7$RightplaneOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Sketch 5" }
                    var sketch = newSketch(context, id + "FT56TNE8MwTVFtD_8", { "sketchPlane" : qUnion([qSpNADYzbvqonE_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                    skPoint(sketch, "0nGY6JnddUDU", { "construction" : false, "index" : "1" });
                    skPoint(sketch, "KkQh5kBb7QGL", { "construction" : false, "index" : "2" });
                    skLineSegment(sketch, "9jFNW5HP7Iio", { "construction" : false, "index" : "7" });
                    skLineSegment(sketch, "dgcwjO6s0Kf1", { "construction" : false, "index" : "8" });
                    skLineSegment(sketch, "Vw7ijmdnV65W", { "construction" : false, "index" : "9" });
                    skLineSegment(sketch, "tOZDGWnr11kI", { "construction" : false, "index" : "10" });
                    {
                        skConstraint(sketch, "1FBBjjLRfOBJ", { "constraintType" : ConstraintType.COINCIDENT, "index" : "9", "name" : "", "localFirst" : "KkQh5kBb7QGL", "localSecond" : "0nGY6JnddUDU" });
                    }
                    {
                        skConstraint(sketch, "dgcwjO6s0Kf1.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "10", "name" : "", "localFirst" : "dgcwjO6s0Kf1.start", "localSecond" : "9jFNW5HP7Iio.end" });
                    }
                    {
                        skConstraint(sketch, "Vw7ijmdnV65W.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "11", "name" : "", "localFirst" : "Vw7ijmdnV65W.start", "localSecond" : "dgcwjO6s0Kf1.end" });
                    }
                    {
                        skConstraint(sketch, "tOZDGWnr11kI.startSnap", { "constraintType" : ConstraintType.COINCIDENT, "index" : "12", "name" : "", "localFirst" : "tOZDGWnr11kI.start", "localSecond" : "Vw7ijmdnV65W.end" });
                    }
                    {
                        skConstraint(sketch, "tOZDGWnr11kI.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "13", "name" : "", "localFirst" : "tOZDGWnr11kI.end", "localSecond" : "9jFNW5HP7Iio.start" });
                    }
                    {
                        skConstraint(sketch, "kkpSnnQi6VbS", { "constraintType" : ConstraintType.PARALLEL, "index" : "2", "name" : "", "localFirst" : "9jFNW5HP7Iio", "localSecond" : "Vw7ijmdnV65W" });
                    }
                    {
                        var zuhxqFrENyBJEf_query;
                        zuhxqFrENyBJEf_query=qCompressed(1.0,"&26e$eJyFUMlymzAYfhn1GE/Eao4YBMaNsSMxqcmFkZFMFNsIC0hCnr4Cpp02PfT2L/Ot31Y2eOy5GrY2OQLGlXjjLFLy6pvBvb5BAzDR0utRVD3thKxD2lEfbo1/P9nQcAJNsMNJnKT+QxGiPUpDlAY58YBUohI1vbQ+nIgp4HUnumFErShAvxdiARTGSLt5EW0n1XxcggAjP0t2qX7IhqtJMmErAyTMhwTChQOi9Kbat/gp3t4/n49hYb4LxXeNVr+NESciBsh3lAXrAqVZkuWEg/bMu/JlNpAwUgLTgkn1nr82w8MntgNXO4r8AGEXL7EXlLOaB6K+ailce85ZuJuNW5iyQR+d6hnHpY5HfqB9VozAMS+GY2nYwCa25gawjZ2/Ke84iEL6eTGtx2ifP234oVjiEjPMtanUvyLzNc0PwyA1FFpfsFDHF4FD0OVmY2u57vcTGLr/U8eQ/hJZMCCHU+n1zsF21XOnxHV3OrWNEnX1hyY24MT81cYdLBeuLuYo5YXTWjaredB12GCLcIx+AgDow7A=",id);
                        var EroySdGYJQMVwX_query;
                        EroySdGYJQMVwX_query=qCompressed(1.0,"&28e$eJyFUctyozAQ/BntMamIp33EIDCsDVgiD3KhBGhtLTbCApJ1vn6FSbJV2UNuo5me7p7Wj5UJdiOTl61FSlAzyV9Y7Utxcu9UB2qg5j09lXw/0oGL1qMDdeBW+3+SXTpGoA4SHAZh7GwKD6Uo9lDs5mQJhOR73tJj70BFbBIKWDvw4TJtrShAnw9iAOQFSHk58H4Qcm4ugIuRk4VJrAaiY/IqGdYrDYS1AwmEtxbw47PsX4KHYHv33JReob9yyZJOqZ+nA69ENSA/UeauCxRnYZYTBvqGDdVhNhDWpAK6AcP9a/67u2zesIktbOMFsQHvyUDl4OOlW82KS+CP+57C9dJquB1FdqGLDv0Z5FgzXE2enbSYjsFwigxrqpUlabJJglyV1wA46x1tSuQDg3VszBl9aP8TvGHA9+jbUTd2fpo/ROypWOAK15gp2+henLrdNmoy64BN11ZB+o6LvjBAFRN3LYKOZxMbi/WYThTqO8gjSrNi2vjODYbVpyhro8fWLJ/g6DUKoWnvEM1QEO3rCTfw162tYiuFODLaim41F8qACUi6CbO/TxHMug==",id);
                        skConstraint(sketch, "kPSFTr8tyljN", { "constraintType" : ConstraintType.PARALLEL, "index" : "3", "name" : "", "externalFirst" : qUnion([qCoEdge(zuhxqFrENyBJEf_query, EroySdGYJQMVwX_query)]), "localSecond" : "Vw7ijmdnV65W" });
                    }
                    {
                        skConstraint(sketch, "oT2um8ZPAoSf", { "constraintType" : ConstraintType.PARALLEL, "index" : "4", "name" : "", "localFirst" : "tOZDGWnr11kI", "localSecond" : "dgcwjO6s0Kf1" });
                    }
                    {
                        skConstraint(sketch, "KtDZZIL10rP9", { "constraintType" : ConstraintType.PERPENDICULAR, "index" : "6", "name" : "", "localFirst" : "Vw7ijmdnV65W", "localSecond" : "dgcwjO6s0Kf1" });
                    }
                    {
                        skConstraint(sketch, "9lXb30Y3JQ3l", { "constraintType" : ConstraintType.LENGTH, "index" : "3", "name" : "", "localFirst" : "Vw7ijmdnV65W", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : -0.6978138665003994, "labelDistance" : 0.011544884152566133 * meter });
                    }
                    {
                        skConstraint(sketch, "ADGrlL1iUGQt", { "constraintType" : ConstraintType.LENGTH, "index" : "4", "name" : "", "localFirst" : "tOZDGWnr11kI", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(12 * millimeter), 'expression' : "12 mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.23569032230041914, "labelDistance" : 0.009990903030380322 * meter });
                    }
                    {
                        var lwRDpoPrSvGsHE_query;
                        lwRDpoPrSvGsHE_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FDazl34QFPYVJeX_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$FcOxZKMCEkNz",id);
                        skConstraint(sketch, "ZXBOwgyScvaM", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "externalFirst" : qUnion([lwRDpoPrSvGsHE_query]), "localSecond" : "Vw7ijmdnV65W", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "halfSpace0" : DimensionHalfSpace.RIGHT, "halfSpace1" : DimensionHalfSpace.RIGHT, "labelRatio" : -1.4029194609695308, "labelDistance" : 0.009133040055748174 * meter });
                    }
                    skSetInitialGuess(sketch, initialGuessFT56TNE8MwTVFtD_8);
                    skSolve(sketch);
                }
            };
        try(features.FT56TNE8MwTVFtD_8(id));
        features.FZDqRtSbp8Wsf7q_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (false)
                {
                    {
                    }
                    var ZBerrLceTbkTNz_query;
                    ZBerrLceTbkTNz_query=qCompressed(1.0,"&21b$eJydkV9vgjAUxb9M97jFMgv4iFC0cYBrG417MUg7rYY/K3WEb7+Ki9myJUv20rT3nPO796Z3UwSez1L3CWLQAUK1eblT+3NuVF1FuckDmDg/Fd43kvmAZ8vsKZtt7FVWRhkl22AcOOHI0nZASK3epYh1XQ6V/GrqL+FpDvDtwcYARzNsIwfVmlr3n/iQ4oCTLLVC3Ug9dCZi6gAiAsggfHBBzJHLU+wnHV/FJtr6ndIya9gEvF22GkACsAXm4XyLU074hknQnqQpDtcBiGAFmBzjdI3mS4+omiLqUo/6dBIWts29ePCAKhutKkML5gGSLClJeQSvi9LxcN5CdEcLKqi0VLEvumPmtqPFK/xigI51wEcK0Z+EVeepYymqlYvW/yOY7CWarSsN4Yn8SqAo9OwHxEGIv2sfXxSn/A==",id);
                    var cMtpRwjaLSLvIA_query;
                    cMtpRwjaLSLvIA_query=qCompressed(1.0,"&1c8$eJx1UE1Pg0AQ/TPj1bhIKRxhWZBYKM6SmnohC2zKpgp0WbT8e0ubeDE9zsyb9/UQrOBtknpOHU4saNQovip1mIRRfRcKI3ySWv8vxTxITp5hi0mcZP6mDFnOspBldM896LU6qE58jr5Nn9IVFyA7o8y8fAUC2N/AbWBhzHgFrRpNr29LFygyv0i22eXQD1JfJZMmsCBpfMIJeXQg6uejpUjavBfdsGlL60dpuR0u6qclzpWoAf7KCvpSsqxIij2XMB6lqdubgaThNRBnntUuGM/co4tXtHGFDq7RRYEV1riAUqyCTsZrg9K7C+oG+d2qeJc3jNwFnaaITfaHqKswRps6lwIin7IFx9egRm6ENhG6tLrl9CCKXXs37WJXtnnR6dLuB3Y2emokVktTfl4uDL8/YpSJ",id);
                    var GxiiZbJIldvnFQ_query;
                    GxiiZbJIldvnFQ_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    annotation { "Feature Name" : "Extrude 6" }
                    extrude(context, id + "FZDqRtSbp8Wsf7q_8", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.REMOVE, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([ZBerrLceTbkTNz_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : true, "depth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : true, "startOffsetBound" : StartOffsetType.ENTITY, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([cMtpRwjaLSLvIA_query]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([GxiiZbJIldvnFQ_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FZDqRtSbp8Wsf7q_8(id));
        features.FHdXRlIvMxW4HKb_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var QNIQCIvJCvNITu_query;
                    QNIQCIvJCvNITu_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromC0M5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FT56TNE8MwTVFtD_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$dgcwjO6s0Kf1C0M5R5R6R7R8R9RbRcRdReSc$Vw7ijmdnV65WR5R6R7R8R9CcA1S11.9$FZDqRtSbp8Wsf7q_8opExtrudeRcSa$SWEPT_EDGER5R6R7R8R9CcA1S-15.7.9$booleanopBooleanRcS4$COPY",id);
                    var rlaQYJEsVTemlA_query;
                    rlaQYJEsVTemlA_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromC0M5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FT56TNE8MwTVFtD_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$9jFNW5HP7IioC0M5R5R6R7R8R9RbRcRdReSc$dgcwjO6s0Kf1R5R6R7R8R9CcA1S11.9$FZDqRtSbp8Wsf7q_8opExtrudeRcSa$SWEPT_EDGER5R6R7R8R9CcA1S-15.7.9$booleanopBooleanRcS4$COPY",id);
                    var LvCIXPqKZOceQS_query;
                    LvCIXPqKZOceQS_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromC0M5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FT56TNE8MwTVFtD_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$Vw7ijmdnV65WC0M5R5R6R7R8R9RbRcRdReSc$tOZDGWnr11kIR5R6R7R8R9CcA1S11.9$FZDqRtSbp8Wsf7q_8opExtrudeRcSa$SWEPT_EDGER5R6R7R8R9CcA1S-15.7.9$booleanopBooleanRcS4$COPY",id);
                    var YUqaAHGQVEKNAw_query;
                    YUqaAHGQVEKNAw_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromC0M5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FT56TNE8MwTVFtD_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$9jFNW5HP7IioC0M5R5R6R7R8R9RbRcRdReSc$tOZDGWnr11kIR5R6R7R8R9CcA1S11.9$FZDqRtSbp8Wsf7q_8opExtrudeRcSa$SWEPT_EDGER5R6R7R8R9CcA1S-15.7.9$booleanopBooleanRcS4$COPY",id);
                    annotation { "Feature Name" : "Fillet 4" }
                    fillet(context, id + "FHdXRlIvMxW4HKb_8", { "filletType" : FilletType.EDGE, "entities" : qUnion([QNIQCIvJCvNITu_query, rlaQYJEsVTemlA_query, LvCIXPqKZOceQS_query, YUqaAHGQVEKNAw_query]), "side1Face" : qUnion([]), "side2Face" : qUnion([]), "centerFaces" : qUnion([]), "tangentPropagation" : true, "blendControlType" : BlendControlType.RADIUS, "crossSection" : FilletCrossSection.CIRCULAR, "radius" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "nonCircularRadius" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "width" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "rho" : { 'value' : try(0.5), 'expression' : "0.5" }.value, "magnitude" : { 'value' : try(0.5), 'expression' : "0.5" }.value, "defaultsChanged" : true, "isAsymmetric" : false, "otherRadius" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipAsymmetric" : false, "isPartial" : false, "startPartialType" : EndTypePartialFillet.PERCENTAGE, "startPartialOffset" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "startPartialEntity" : qUnion([]), "partialFirstEdgeTotalParameter" : { 'value' : try(0.01), 'expression' : "0.01" }.value, "partialOppositeParameter" : true, "useTrimmedFirstBound" : false, "secondBound" : false, "endPartialType" : EndTypePartialFillet.PERCENTAGE, "endPartialOffset" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endPartialEntity" : qUnion([]), "useTrimmedSecondBound" : false, "partialSecondEdgeTotalParameter" : { 'value' : try(0.99), 'expression' : "0.99" }.value, "isVariable" : false, "vertexSettings" : [], "pointOnEdgeSettings" : [], "smoothTransition" : false, "allowEdgeOverflow" : true, "keepEdges" : qUnion([]), "smoothCorners" : false, "smoothCornerExceptions" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FHdXRlIvMxW4HKb_8(id));
        features.FLtu5wl8vVP8uFq_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var AaYsKqfRasFbwv_query;
                    AaYsKqfRasFbwv_query=qCompressed(1.0,"&1bb$eJx9UEtzgjAQ/jPbYx2DPPTII2q0gk1oO5yYRKKkKqEQpvXfF2Sml8543P12v9dT4MBrJ5vbzmHIgkK1/CrUqeNG6SrihvtoZ/1H0lstGZpBQsmKxP5LHuE9jiMchxlbgG7USVX80vp2OO2JOcjKKHMbvgIO+G9gNuBohZmAUrVGN+NyDiHFfkqSuAd0LZu7JCkCC0jhI4bQxIXlJXHdt7XPNjskqi73vlUjk7pX/xri3IkKYFuchuscxylJMyahPUtzKEcDpGCHnujtnNjv7amxsj0R2hh9HTxTmzrUpR6dU04FPdCCPSNrMgOj6we4DRd5NA8OHOi7KQ21Q7cPHyRRNh6FYgy2gKX45NtZGZPpxvXwMfd0jX9M0xWSir5J9oH3aT48/gKHAY4R",id);
                    annotation { "Feature Name" : "Transform 4" }
                    transform(context, id + "FLtu5wl8vVP8uFq_8", { "entities" : qUnion([AaYsKqfRasFbwv_query]), "transformType" : TransformType.TRANSLATION_3D, "oppositeDirectionEntity" : false, "transformLine" : qUnion([]), "transformAxis" : qUnion([]), "transformDirection" : qUnion([]), "distance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "uniform" : true, "scale" : { 'value' : try(1), 'expression' : "1" }.value, "scaleX" : { 'value' : try(1), 'expression' : "1" }.value, "scaleY" : { 'value' : try(1), 'expression' : "1" }.value, "scaleZ" : { 'value' : try(1), 'expression' : "1" }.value, "baseConnector" : qUnion([]), "destinationConnector" : qUnion([]), "oppositeDirectionMateAxis" : false, "secondaryAxisType" : MateConnectorAxisType.PLUS_X, "angle" : { 'value' : try(30 * degree), 'expression' : "30 deg" }.value, "oppositeDirection" : false, "dx" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "dy" : { 'value' : try(4 * millimeter), 'expression' : "4 mm" }.value, "dz" : { 'value' : try(7 * millimeter), 'expression' : "7 mm" }.value, "scalePoint" : qUnion([]), "makeCopy" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FLtu5wl8vVP8uFq_8(id));
        features.Ff3uAryMmkQtUPP_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFf3uAryMmkQtUPP_8 = { "BEa1tHAo2xFc" : [0.1137335922514775, -0.004970635022946632, 1.0, 4.336808689942014E-17, -0.010000000000000009, 0.010000000000000009], "BYqiPCQDCZVz" : [0.1185218982633893, -0.004970635022946632], "4HeCkFXklcEL" : [0.1082062272178202, -0.004970635022946632] };
                    {
                    }
                    var XEYWVDODUOgZqr_query;
                    XEYWVDODUOgZqr_query=qCompressed(1.0,"&1c4$eJx9UE1zgjAU/DOvxzoG+dBjhKDRAjbBznhiEomSqkBDnNZ/X9CZXjrj8b3dt293X+YevF+VuSU+Rw6UuhMXqY9XYXVTR8IKjBLnP5LfWsXRBDJGFzTFb0VENiSNSBru+Awao4+6FucOu+E48bgAVVttb8PVXAD5G7gLJFoQLqHSnW3MYzmFkBGc0yztgaZV5v6SlnMHaIkRR2jkQ3zOfH+7xHyVIFlfi+BbG5W1/fevIc5dqAS+Jnm4LEia03zHFXQnZffVwwAt+b4X2p4y96M7Gme3obKxtrkMnpnLPOazgE2ZYJLtWclfkTOagG3aJ7gLZ3WwTwge9N1Ulrmh34ePcUgGEg9Ad9wKY2M2DeUj4wxi+SnWkyql45UfkEMRNC35seZaKiaHlvCmGBR+AaOSkMo=",id);
                    annotation { "Feature Name" : "Sketch 8" }
                    var sketch = newSketch(context, id + "Ff3uAryMmkQtUPP_8", { "sketchPlane" : qUnion([XEYWVDODUOgZqr_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                    skLineSegment(sketch, "BEa1tHAo2xFc", { "construction" : true, "index" : "1" });
                    skPoint(sketch, "BYqiPCQDCZVz", { "construction" : false, "index" : "1" });
                    skPoint(sketch, "4HeCkFXklcEL", { "construction" : false, "index" : "2" });
                    {
                        var FPyDcfIvEQGpyx_query;
                        FPyDcfIvEQGpyx_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6$UkO4Vsgr2YPIbottomR4R5R6R7S7$isStartFR8CbA1S11.9$FbjaK3hNI0J67Ef_7opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "BEa1tHAo2xFc.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "BEa1tHAo2xFc.start", "externalSecond" : qUnion([FPyDcfIvEQGpyx_query]) });
                    }
                    {
                        var cnpoyLWSXxFIpB_query;
                        cnpoyLWSXxFIpB_query=qCompressed(1.0,"&27f$eJx9UU2XmjAU/TOvSz0TPmUZIYxoBZswbV1xAgSlKqEhtuO/b4DTdjFnZpfk3nc/Xj6tXfhyF+qxd1kJtVDtL1HHSt6wFT7tPYYsqNuB38r2dOe6lV3ENcdob71F8kcvGLIho8lzkuLPRUQOJI1IGh5ZAFK1p7bj1wE7RthlHESnW/0Yp9YcyL8Lc4BEz8SkObeDlmp+XEFICc6TLDWA7IWaLJN6bUFSY8QQWnoQXzPPe9lgtt2jsrsX/u9Wiaw37j/HipNQDWxH8nBTkDRP8iMTMFyErs5zgKRmlRF6uWTO1+GkrOMhKaXW8jZmpi71qE9XNKAlrWhNBVsge2mDlv0HuANX0egPCC6Y3Zw1dUPflI9xSEYS86EdmOZKxzQIq7ljAHH5g+/sc5o8bT2fNIUve/Kq1b0WtBq3hA/FqDDZofGjqEVt6mD0ToBquUAr0JvjobwqvItWsSEhPrP+2i5QA7HLmtASwfZW5c33S7EyfhzYN3LIJ8f/2tPUwnKWvslbSnkVvJP9ej6YqQCSNCeUkTD/AyxVyDk=",id);
                        skConstraint(sketch, "BEa1tHAo2xFc.endSnap0", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "BEa1tHAo2xFc", "externalSecond" : qUnion([cnpoyLWSXxFIpB_query]) });
                    }
                    {
                        var lpdCZhwjcnFBGw_query;
                        lpdCZhwjcnFBGw_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FlO66UHASJM1bnu_7wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$UkO4Vsgr2YPItopC0M5R4R5R6R7R8RaRbRcRdSc.4$tHYPblrAKD8FleftR4C6S6$VERTEXR6R7S7$isStartTR8CbA1S11.9$F5SfC2e9JmcTfXk_8opExtrudeRbSa$CAP_VERTEX",id);
                        skConstraint(sketch, "BEa1tHAo2xFc.endSnap1", { "constraintType" : ConstraintType.VERTICAL, "index" : "1", "name" : "", "localFirst" : "BEa1tHAo2xFc.end", "externalSecond" : qUnion([lpdCZhwjcnFBGw_query]) });
                    }
                    {
                        skConstraint(sketch, "BYqiPCQDCZVz.positionSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "BYqiPCQDCZVz", "localSecond" : "BEa1tHAo2xFc" });
                    }
                    {
                        skConstraint(sketch, "4HeCkFXklcEL.positionSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "4HeCkFXklcEL", "localSecond" : "BEa1tHAo2xFc" });
                    }
                    skSetInitialGuess(sketch, initialGuessFf3uAryMmkQtUPP_8);
                    skSolve(sketch);
                }
            };
        try(features.Ff3uAryMmkQtUPP_8(id));
        features.FK68bV8IlQ0da2b_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var szPJpgXwpitBmN_query;
                    szPJpgXwpitBmN_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Ff3uAryMmkQtUPP_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$BYqiPCQDCZVz",id);
                    var GNNrwruQwFnpMG_query;
                    GNNrwruQwFnpMG_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Ff3uAryMmkQtUPP_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$4HeCkFXklcEL",id);
                    var xbHrxiCsvpLHAU_query;
                    xbHrxiCsvpLHAU_query=qCompressed(1.0,"&1bb$eJx9UEtzgjAQ/jPbYx2DPPTII2q0gk1oO5yYRKKkKqEQpvXfF2Sml8543P12v9dT4MBrJ5vbzmHIgkK1/CrUqeNG6SrihvtoZ/1H0lstGZpBQsmKxP5LHuE9jiMchxlbgG7USVX80vp2OO2JOcjKKHMbvgIO+G9gNuBohZmAUrVGN+NyDiHFfkqSuAd0LZu7JCkCC0jhI4bQxIXlJXHdt7XPNjskqi73vlUjk7pX/xri3IkKYFuchuscxylJMyahPUtzKEcDpGCHnujtnNjv7amxsj0R2hh9HTxTmzrUpR6dU04FPdCCPSNrMgOj6we4DRd5NA8OHOi7KQ21Q7cPHyRRNh6FYgy2gKX45NtZGZPpxvXwMfd0jX9M0xWSir5J9oH3aT48/gKHAY4R",id);
                    var UrMXmpvfTxkdse_query;
                    UrMXmpvfTxkdse_query=qCompressed(1.0,"&515$eJydkttymzAQhl9GvbTHEudLDCIhiYGsSFtfMWBErPoABbmN374CcrBTt830hhHa3f/b/Vef5ga6P/D2uDAYJqgUXb4rxOMhl6Le+7nMXbwgv0fSY8OZjdI4ie/iq6U68r0UUvDONV3izZRagUreih+8DNp6p25MmPVagBnWUAzhVRi5d5lPExr5NPKWzEF1Kx7FPt92Lh4k8lH12NPmOaKvP0xH1L+iirEWnazb43M/HlA3DeNIBeqGt0OrYTknKCxdxcVTEwXb2DQfrl12s8DF/pBZP0XL40bRv/c2DEIlYrc09a4zGqVhumQcdRsuV+uxgbBkKyX0sIn1z91jS5ZJWNRS1juwwAYHcmYh0TGZtzKAwuMj2UFB8S2/1dZROLsxLVplVt3QJ9keSg5D726S9UO9qLyVWiiotIOrdrTb3MuHJMlssWtasZeq0ELhIoEwSn08Gg/6qdlggDm6+aYLJXCoAM/YBBtTHW15JV+j2FRNA7ZVCnZOavCqvyn9yX9iDKSWu/4wB3B1wlHf4e+cpwMmf0NqSNYNEAKkAMtz1KMJXI++oz8730cGrQ8NtJpOiFK/XibFtnVvfTtQWZp1vrYJzlFgsMoj3LnZrdLq6ybrgTliX2iSDsh3y56QYmqpp1LU9Zbn+7qZjwdV5SC1YwqMeum/3DIv7QY07Q/ev6QR0J5FZkCMk4HGTB1/3J8JcZRDGJ2K6LNB5CRdN9RcBmLJXXhpJmKfzwR6eblXfqFX0Mk7Ehj2RchZ8Xj7C1ypgX0=",id);
                    annotation { "Feature Name" : "#featureName" }
                    hole(context, id + "FK68bV8IlQ0da2b_8", { "isV2" : true, "holeVersion" : HoleVersion.V3, "initEntities" : qUnion([]), "featureName" : "Ø #holeDiameterV3 ↧ #holeDepthV3", "threadStandard" : ThreadStandard.UNSET, "hasClearance" : false, "unitsSystem" : UnitsSystem.METRIC, "styleV2" : HoleStyle.SIMPLE, "style" : HoleStyle.SIMPLE, "locations" : qUnion([szPJpgXwpitBmN_query, GNNrwruQwFnpMG_query]), "scope" : qUnion([xbHrxiCsvpLHAU_query]), "ansiHoleTableEx" : lookupTablePath({ "size" : "1/4 (0.25)", "holeType" : "Drilled" }), "ansiHoleTable" : lookupTablePath({ "size" : "1/4 (0.25)", "holeType" : "Drilled" }), "isoHoleTableEx" : lookupTablePath({ "fit" : "Normal", "size" : "M3.5", "holeType" : "Clearance" }), "isoHoleTable" : lookupTablePath({ "fit" : "Close", "size" : "M3.5", "holeType" : "Clearance" }), "showThreadClassV2" : false, "ansiThreadClassV2" : lookupTablePath({ "class" : "2B" }), "isoThreadClassV2" : lookupTablePath({ "class" : "6H" }), "showTappedDepth" : false, "holeDiameterV3" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "tapDrillDiameterV3" : { 'value' : try(3.75 * millimeter), 'expression' : "3.75 mm" }.value, "holeDiameterV2" : 2.0 * millimeter, "holeDiameterV2Precision" : PrecisionType.DEFAULT, "holeDiameterV2ToleranceType" : ToleranceTypeExtended.NONE, "holeDiameterV2ToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2ToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2ToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterV2ToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2ToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterV2FitToleranceTable" : lookupTablePath({ "fit" : "User defined", "standard" : "ISO", "shaftClass" : "None", "holeClass" : "A9" }), "holeDiameterV2holeClassToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2holeClassToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tapDrillDiameterV2" : { 'value' : try(3.75 * millimeter), 'expression' : "3.75 mm" }.value, "tapDrillDiameterV2Precision" : PrecisionType.DEFAULT, "tapDrillDiameterV2ToleranceType" : ToleranceType.NONE, "tapDrillDiameterV2ToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "startStyle" : HoleStartStyle.PLANE, "startBoundEntity" : qUnion([UrMXmpvfTxkdse_query]), "endStyleV2" : HoleEndStyleV2.BLIND, "endStyle" : HoleEndStyle.BLIND, "oppositeDirection" : false, "endBoundEntity" : qUnion([]), "offset" : false, "offsetDistance" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeOffsetDirection" : false, "standardTappedOrClearance" : lookupTablePath({ "standard" : "Custom" }), "standardBlindInLast" : lookupTablePath({ "standard" : "Custom" }), "showThreadClass" : false, "ansiThreadClass" : lookupTablePath({ "class" : "2B" }), "isoThreadClass" : lookupTablePath({ "class" : "6H" }), "holeDiameter" : 2.0 * millimeter, "holeDiameterPrecision" : PrecisionType.DEFAULT, "holeDiameterToleranceType" : ToleranceTypeExtended.NONE, "holeDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterFitToleranceTable" : lookupTablePath({ "fit" : "User defined", "standard" : "ISO", "shaftClass" : "None", "holeClass" : "A9" }), "holeDiameterholeClassToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterholeClassToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDiameterV3" : { 'value' : try(7.375 * millimeter), 'expression' : "7.375 mm" }.value, "cBoreDepthV3" : { 'value' : try(3.5 * millimeter), 'expression' : "3.5 mm" }.value, "cBoreDiameter" : { 'value' : try(7.375 * millimeter), 'expression' : "7.375 mm" }.value, "cBoreDiameterPrecision" : PrecisionType.DEFAULT, "cBoreDiameterToleranceType" : ToleranceType.NONE, "cBoreDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDepth" : { 'value' : try(3.5 * millimeter), 'expression' : "3.5 mm" }.value, "cBoreDepthPrecision" : PrecisionType.DEFAULT, "cBoreDepthToleranceType" : ToleranceType.NONE, "cBoreDepthToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDepthToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDepthToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDepthToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDepthToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cSinkDiameterV3" : { 'value' : try(7.84 * millimeter), 'expression' : "7.84 mm" }.value, "cSinkAngleV3" : { 'value' : try(90 * degree), 'expression' : "90 degree" }.value, "cSinkDiameter" : { 'value' : try(7.84 * millimeter), 'expression' : "7.84 mm" }.value, "cSinkDiameterPrecision" : PrecisionType.DEFAULT, "cSinkDiameterToleranceType" : ToleranceType.NONE, "cSinkDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cSinkDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cSinkDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cSinkDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cSinkDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cSinkAngle" : { 'value' : try(90 * degree), 'expression' : "90 degree" }.value, "cSinkAnglePrecision" : PrecisionType.DEFAULT, "cSinkAngleToleranceType" : ToleranceType.NONE, "cSinkAngleToleranceBoundSymmetrical" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "cSinkAngleToleranceBoundDeviationUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "cSinkAngleToleranceBoundDeviationLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "cSinkAngleToleranceBoundLimitsUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "cSinkAngleToleranceBoundLimitsLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "tapDrillDiameter" : { 'value' : try(3.75 * millimeter), 'expression' : "3.75 mm" }.value, "tapDrillDiameterPrecision" : PrecisionType.DEFAULT, "tapDrillDiameterToleranceType" : ToleranceType.NONE, "tapDrillDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tapDrillDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "majorDiameter" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "isMultiple" : false, "holeDepthMultiple" : "Multiple", "holeDepthMultiplePrecision" : PrecisionType.DEFAULT, "holeDepthMultipleToleranceType" : ToleranceType.NONE, "holeDepthMultipleToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthMultipleToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthMultipleToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthMultipleToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthMultipleToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthComputedV3" : { 'value' : try(12 * millimeter), 'expression' : "12 mm" }.value, "holeDepthComputed" : { 'value' : try(12 * millimeter), 'expression' : "12 mm" }.value, "holeDepthComputedPrecision" : PrecisionType.DEFAULT, "holeDepthComputedToleranceType" : ToleranceType.NONE, "holeDepthComputedToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthComputedToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthComputedToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthComputedToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthComputedToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthV3" : { 'value' : try(2.7 * millimeter), 'expression' : "2.7 mm" }.value, "holeDepth" : { 'value' : try(2.7 * millimeter), 'expression' : "2.7 mm" }.value, "holeDepthPrecision" : PrecisionType.DEFAULT, "holeDepthToleranceType" : ToleranceType.NONE, "holeDepthToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tipAngleStyle" : TipAngleStyle.DEGREE118, "tipAngleV3" : { 'value' : try(118 * degree), 'expression' : "118 deg" }.value, "tipAngle" : { 'value' : try(118 * degree), 'expression' : "118 deg" }.value, "tipAnglePrecision" : PrecisionType.DEFAULT, "tipAngleToleranceType" : ToleranceType.NONE, "tipAngleToleranceBoundSymmetrical" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "tipAngleToleranceBoundDeviationUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "tipAngleToleranceBoundDeviationLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "tipAngleToleranceBoundLimitsUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "tipAngleToleranceBoundLimitsLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "isTappedThrough" : true, "tappedDepthV3" : { 'value' : try(6.9 * millimeter), 'expression' : "6.9 mm" }.value, "tappedDepth" : { 'value' : try(6.9 * millimeter), 'expression' : "6.9 mm" }.value, "tappedDepthPrecision" : PrecisionType.DEFAULT, "tappedDepthToleranceType" : ToleranceType.NONE, "tappedDepthToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tappedDepthToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tappedDepthToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tappedDepthToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tappedDepthToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tappedAngle" : { 'value' : try(1.789911 * degree), 'expression' : "1.789911 deg" }.value, "tapClearance" : { 'value' : try(3), 'expression' : "3" }.value, "toleranceMatching" : { 'value' : try({ "cBoreDepth" : "cBoreDepthV3", "cBoreDiameter" : "cBoreDiameterV3", "cSinkAngle" : "cSinkAngleV3", "cSinkDiameter" : "cSinkDiameterV3", "holeDepth" : "holeDepthV3", "holeDepthComputed" : "holeDepthComputedV3", "holeDiameter" : "holeDiameterV2", "holeDiameterV2" : "holeDiameterV3", "tapDrillDiameter" : "tapDrillDiameterV2", "tapDrillDiameterV2" : "tapDrillDiameterV3", "tappedDepth" : "tappedDepthV3", "tipAngle" : "tipAngleV3" }), 'expression' : "{\"cBoreDepth\" : \"cBoreDepthV3\", \"cBoreDiameter\" : \"cBoreDiameterV3\", \"cSinkAngle\" : \"cSinkAngleV3\", \"cSinkDiameter\" : \"cSinkDiameterV3\", \"holeDepth\" : \"holeDepthV3\", \"holeDepthComputed\" : \"holeDepthComputedV3\", \"holeDiameter\" : \"holeDiameterV2\", \"holeDiameterV2\" : \"holeDiameterV3\", \"tapDrillDiameter\" : \"tapDrillDiameterV2\", \"tapDrillDiameterV2\" : \"tapDrillDiameterV3\", \"tappedDepth\" : \"tappedDepthV3\", \"tipAngle\" : \"tipAngleV3\"}" }.value, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.FK68bV8IlQ0da2b_8(id));
        features.F4q7MG087crPxlb_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (!switch (configuration.List_5KGcbwyvF0AOZo) { List_5KGcbwyvF0AOZo_conf.Default : true, List_5KGcbwyvF0AOZo_conf.Sharp : true, List_5KGcbwyvF0AOZo_conf.Bevel : false })
                {
                    {
                    }
                    var gppheZfcREZNCh_query;
                    gppheZfcREZNCh_query=qCompressed(1.0,"&25d$eJxtkFtTo0AQhf/M7KMWQwIhj1yGS0UI28OulScKmFaGGAaBqPx7IbG0Sn2c7p5zvnP+OAb5e8Z+ig1eEoG9fEHh9+pk6642z6hOhByKUykfz8UoVesVY2HTWP+5yaYOOV2RPURBlNh3ucdSlngscQ98S1QvH2VbPA0fwgXBdpTjtPxyCsI+H3xNmBewmaaWw6j669AiLjA7i/bJvFAd9hfLSDg6iYRNOaW3JvFlMDQ2X+9MzSoeqlx7lT3uu9n9eYl4ERKE71jmhjlLsig7cCTDEceqvgJEgleEh6VfWacDYrJZWMEAEzZgwRZKqEAAzkdd+O9YQlayV25+HbjVlWVL/NivvYdD86w3u7Md55rq2NvYnwVCNYfn9yzN8iXoxYEulYIOK1hf+/kpeYPEV9NRlzQW91nb3dW5/kkTQ+m0GGxGwO03ZPrF3Hb4UsvgfyoY/cWAzg02a9g40ahUeAqn9OJArV/z6Y5jaN4x26m0QTNfqc5R6gmLds5nkJhBwN4BVrm/gQ==",id);
                    var KerqOPbSSnNClF_query;
                    KerqOPbSSnNClF_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$npevhiGVPdE1C0M5R4R5R6R7R8RaRbRcRdSc$quFEu4ZacbDGR4R5R6R7R8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$SWEPT_EDGE",id);
                    var dqpSTxnIvvvcfS_query;
                    dqpSTxnIvvvcfS_query=qCompressed(1.0,"&25d$eJxtkEtzozAQhP+M9pgthAHbRx4CUzaYHbGb8l4ogZQgiBHmkYR/H7C34qpNjpoZdX/dPxwT/RpFN0UmzREXnXwV3O/U2dZdbZ5hHXHZs3Mun0c2SNV4bGA2jvSvm3RqBcUrdIQwCGP7kHkkIbFHYvdEt0h18lk27KX/J8yQaAY5TMsvhyHy+aAGIl5AZppS9oPqbsMNcoHYaXiM54VqRXe1DLmjo5DbmGL800K+DPrKpsbe0jbsqci0N9mJYzu7X5aIVyGO6J6k7i4jcRqmJypQX4uhKG8AIacFiqChvXfQ6rUGCyuYYMEaNrCFHArgIOajdve7ziHNyRu17gducWPZIj/yS+/pVF30aj/aUaaplrwP3cgFFHN4+kiSNFuCXh3wUinosALj1s9XyQeBfDXVusQRf0yb9lBm+idN04rXUgZ/Ek7wf8j4znwZfTIaf1mRe8E3BnhusDJg7YSDUrvzbkquDnjzbT7dcUzNq9O9SiphZSvVOkq9CNbM+UwUEQjIBy0Jv3I=",id);
                    var oxExfStbTbnlEz_query;
                    oxExfStbTbnlEz_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$Foyk2i1MdWTnpLh_2wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$MRbBneG7tRe9C0M5R4R5R6R7R8RaRbRcRdSc$npevhiGVPdE1R4R5R6R7R8CbA1S11.9$FG84VuVG8ehPTnr_4opExtrudeRbSa$SWEPT_EDGE",id);
                    annotation { "Feature Name" : "Lower Lip Chamf" }
                    chamfer(context, id + "F4q7MG087crPxlb_8", { "entities" : qUnion([gppheZfcREZNCh_query, KerqOPbSSnNClF_query, dqpSTxnIvvvcfS_query, oxExfStbTbnlEz_query]), "chamferMethod" : ChamferMethod.FACE_OFFSET, "chamferType" : ChamferType.EQUAL_OFFSETS, "width" : { 'value' : try(lookup('Lower_Lip_Bevel')), 'expression' : "#Lower_Lip_Bevel" }.value, "width1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeDirection" : false, "width2" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "angle" : { 'value' : try(45 * degree), 'expression' : "45 deg" }.value, "directionOverrides" : qUnion([]), "tangentPropagation" : true, "asVersion" : FeatureScriptVersionNumber.V3044_SWEEP_EXTEND_OPTION_REVERT });
                }
            };
        try(features.F4q7MG087crPxlb_8(id));
        features.Fots71D8KQhdREP_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var FKaQjqqeJcDctS_query;
                    FKaQjqqeJcDctS_query=qCompressed(1.0,"&1c8$eJx1UE1TgzAQ/TPx6hikUI4QAs1YaN0wdeqFCSRTYi2hEFT+vaWd8eL0uLtv39dDtECvo+qnzOPYQVIP4lTpwyisNm0srAhx5vy/FFOnOH5GG2Apy8N1GdMtzWOakz0PkOn1Qbficwhd8pQtuECqtdpO81ckEP0buItonFJeoUYP1vS35RIRoGHBNvnlYDrVXyWZjBzEZIg5xo8eSsx0dDTO5FvRduumdL51rzbdRf08x7kSScRfaEFWJc0LVuy5QsNR2bq5GWCS1wh706R30fDDAzJ7BRcW4IEPSxBQQQ0zKIMqalXqW1DBXVDbqa9Gp7utpPgu6DwmdHTfRV3FKbjEuxSQhITOOO4jPXArepvAklS3nAFKPlzwI2aNWZ1W07Z0TEd/bD9KBdXcVLgtZ4ZfROOUrQ==",id);
                    var SDRrlGHhyppCBR_query;
                    SDRrlGHhyppCBR_query=qCompressed(1.0,"&1c8$eJx1UE1Pg0AQ/TPj1bhIKRxhWZBYKM6SmnohC2zKpgp0WbT8e0ubeDE9zsyb9/UQrOBtknpOHU4saNQovip1mIRRfRcKI3ySWv8vxTxITp5hi0mcZP6mDFnOspBldM896LU6qE58jr5Nn9IVFyA7o8y8fAUC2N/AbWBhzHgFrRpNr29LFygyv0i22eXQD1JfJZMmsCBpfMIJeXQg6uejpUjavBfdsGlL60dpuR0u6qclzpWoAf7KCvpSsqxIij2XMB6lqdubgaThNRBnntUuGM/co4tXtHGFDq7RRYEV1riAUqyCTsZrg9K7C+oG+d2qeJc3jNwFnaaITfaHqKswRps6lwIin7IFx9egRm6ENhG6tLrl9CCKXXs37WJXtnnR6dLuB3Y2emokVktTfl4uDL8/YpSJ",id);
                    annotation { "Feature Name" : "Chamfer 2" }
                    chamfer(context, id + "Fots71D8KQhdREP_8", { "entities" : qUnion([FKaQjqqeJcDctS_query, SDRrlGHhyppCBR_query]), "chamferMethod" : ChamferMethod.APEX_RANGE, "chamferType" : ChamferType.EQUAL_OFFSETS, "width" : { 'value' : try(1.5 * millimeter), 'expression' : "1.5 mm" }.value, "width1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeDirection" : false, "width2" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "angle" : { 'value' : try(45 * degree), 'expression' : "45 deg" }.value, "directionOverrides" : qUnion([]), "tangentPropagation" : true, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.Fots71D8KQhdREP_8(id));
        features.FnPuTavsx1H4H3I_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    const initialGuessFnPuTavsx1H4H3I_8 = { "Fk4AqacuMr7m" : [0.09922593086957932, -0.009112847660378664, 1.0, 1.2246467991473532E-16, 0.002654069130420683, 0.018654069130420683], "mNKPWXlU2aOo" : [0.09988, -0.009112847660378662], "7LG4cbEEpAVp" : [0.0930175930261612, -0.009112847660378664, -1.0, -1.2246467991473532E-16, -0.008862406973838804, -0.006862406973838803], "bmOUNP7TRGj9" : [0.11376812309026718, -0.009112847660378662, -1.0, -2.2297898609042257E-16, -0.00711187690973282, 0.00888812309026718] };
                    {
                    }
                    var tIqyCuelXGQXLl_query;
                    tIqyCuelXGQXLl_query=qCompressed(1.0,"&222$eJxlkEFz2jAUhP+MekymAss2RyPLxE1tyJMGQi4eYSmJGrCMLUrIr68waSZpb5Ke9u23+21K0N1Bd6ci5BukdGd+a5V1dpdg+r0gHI+QMr3cbczTQTpjm1Q6meBi9P9EnFrN8RjNIZ/lZfKzStmClSkr6ZpPkO3Mk2nktn9fLJFunHGns2oqEfu48ACxdMY8zbPpne0ujzGiwBKRz0s/sK3uBstcTUcoVwnmGF+HKEvl23Yc3GWL9fKHvq/io+n0vPXu+3PEYZFC/JYJelOxUuRizTXqX7Srny8AueI1yur568NtQdlL+QaERp4oSyiDCGKY0PriNkGZoSFn2z2BIL45LKrYtuzVdQelofbx+IotRDUICeDAQzz6WoW1fysAfO4RRjCG4P2FQPjV5UqjTJBQlCwujmKZubSKoQYF2nMuj5H5tVPNMiSrweMfLfaNPKR7cHzTxqv+MdoPYhx9+neF1XXkw2w8l5aNbaeXg49AUMFgxv4AePitcA==",id);
                    annotation { "Feature Name" : "Sketch 7" }
                    var sketch = newSketch(context, id + "FnPuTavsx1H4H3I_8", { "sketchPlane" : qUnion([tIqyCuelXGQXLl_query]), "disableImprinting" : false, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                    skLineSegment(sketch, "Fk4AqacuMr7m", { "construction" : true, "index" : "1" });
                    skPoint(sketch, "mNKPWXlU2aOo", { "construction" : false, "index" : "1" });
                    skLineSegment(sketch, "7LG4cbEEpAVp", { "construction" : true, "index" : "2" });
                    skLineSegment(sketch, "bmOUNP7TRGj9", { "construction" : true, "index" : "3" });
                    {
                        var bVdxXhVZEDDNCV_query;
                        bVdxXhVZEDDNCV_query=qCompressed(1.0,"%B5$QueryM5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FDazl34QFPYVJeX_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$opeAQwTIDScfC0M5R4R5R6R7R8RaRbRcRdSc$FcOxZKMCEkNzR4R5R6R7R8CbA1S11.9$FiC6SElq5R48HuP_8opExtrudeRbSa$SWEPT_EDGE",id);
                        skConstraint(sketch, "Fk4AqacuMr7m.endSnap0", { "constraintType" : ConstraintType.PARALLEL, "index" : "1", "name" : "", "localFirst" : "Fk4AqacuMr7m", "externalSecond" : qUnion([bVdxXhVZEDDNCV_query]) });
                    }
                    {
                        skConstraint(sketch, "S8ZpqdXS3BiE", { "constraintType" : ConstraintType.LENGTH, "index" : "1", "name" : "", "localFirst" : "Fk4AqacuMr7m", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(16 * millimeter), 'expression' : "16 mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 0.5, "labelDistance" : -0.0032942212476459003 * meter });
                    }
                    {
                        var ySixdCtbjWsYXz_query;
                        ySixdCtbjWsYXz_query=qCompressed(1.0,"&222$eJxlkEFz2jAUhP+MekymAss2RyPLxE1tyJMGQi4eYSmJGrCMLUrIr68waSZpb5Ke9u23+21K0N1Bd6ci5BukdGd+a5V1dpdg+r0gHI+QMr3cbczTQTpjm1Q6meBi9P9EnFrN8RjNIZ/lZfKzStmClSkr6ZpPkO3Mk2nktn9fLJFunHGns2oqEfu48ACxdMY8zbPpne0ujzGiwBKRz0s/sK3uBstcTUcoVwnmGF+HKEvl23Yc3GWL9fKHvq/io+n0vPXu+3PEYZFC/JYJelOxUuRizTXqX7Srny8AueI1yur568NtQdlL+QaERp4oSyiDCGKY0PriNkGZoSFn2z2BIL45LKrYtuzVdQelofbx+IotRDUICeDAQzz6WoW1fysAfO4RRjCG4P2FQPjV5UqjTJBQlCwujmKZubSKoQYF2nMuj5H5tVPNMiSrweMfLfaNPKR7cHzTxqv+MdoPYhx9+neF1XXkw2w8l5aNbaeXg49AUMFgxv4AePitcA==",id);
                        var iqzECtNjQLUsRu_query;
                        iqzECtNjQLUsRu_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FDazl34QFPYVJeX_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$FcOxZKMCEkNzR4R5R6R7S7$isStartTR8CbA1S11.9$FiC6SElq5R48HuP_8opExtrudeRbS8$CAP_EDGE",id);
                        skConstraint(sketch, "mNKPWXlU2aOo.positionSnap0", { "constraintType" : ConstraintType.MIDPOINT, "index" : "1", "name" : "", "localEntity1" : "mNKPWXlU2aOo", "externalEntity2" : qUnion([qCoEdge(ySixdCtbjWsYXz_query, iqzECtNjQLUsRu_query)]) });
                    }
                    {
                        skConstraint(sketch, "7LG4cbEEpAVp.startSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "1", "name" : "", "localFirst" : "7LG4cbEEpAVp.start", "localSecond" : "Fk4AqacuMr7m.start" });
                    }
                    {
                        skConstraint(sketch, "7LG4cbEEpAVp.endSnap0", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "1", "name" : "", "localFirst" : "7LG4cbEEpAVp" });
                    }
                    {
                        skConstraint(sketch, "gHoc2ruFMzre", { "constraintType" : ConstraintType.LENGTH, "index" : "2", "name" : "", "localFirst" : "7LG4cbEEpAVp", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "alignment" : DimensionAlignment.ALIGNED, "labelRatio" : 1.8937105735143014, "labelDistance" : 0.003294216832483582 * meter });
                    }
                    {
                        skConstraint(sketch, "ck6EJdRO3Lpu0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "2", "name" : "", "localFirst" : "7LG4cbEEpAVp.end", "localSecond" : "mNKPWXlU2aOo" });
                    }
                    {
                        skConstraint(sketch, "bmOUNP7TRGj9.startSnap0", { "constraintType" : ConstraintType.HORIZONTAL, "index" : "2", "name" : "", "localFirst" : "bmOUNP7TRGj9.start", "localSecond" : "Fk4AqacuMr7m.end" });
                    }
                    {
                        skConstraint(sketch, "bmOUNP7TRGj9.endSnap0", { "constraintType" : ConstraintType.COINCIDENT, "index" : "3", "name" : "", "localFirst" : "bmOUNP7TRGj9.end", "localSecond" : "Fk4AqacuMr7m" });
                    }
                    {
                        skConstraint(sketch, "GvjvuqQBdsyf", { "constraintType" : ConstraintType.DISTANCE, "index" : "1", "name" : "", "localFirst" : "Fk4AqacuMr7m.start", "localSecond" : "bmOUNP7TRGj9.end", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(3 * millimeter), 'expression' : "3 mm" }.value, "labelRatio" : 1.897760221902589, "labelDistance" : -0.023749311430823636 * meter });
                    }
                    {
                        skConstraint(sketch, "wrYI3wD9U0m9", { "constraintType" : ConstraintType.DISTANCE, "index" : "2", "name" : "", "localFirst" : "bmOUNP7TRGj9.end", "localSecond" : "bmOUNP7TRGj9.start", "direction" : DimensionDirection.MINIMUM, "length" : { 'value' : try(16 * millimeter), 'expression' : "16 mm" }.value, "labelRatio" : -0.5273559533754989, "labelDistance" : 0.0126971932678024 * meter });
                    }
                    skSetInitialGuess(sketch, initialGuessFnPuTavsx1H4H3I_8);
                    skSolve(sketch);
                }
            };
        try(features.FnPuTavsx1H4H3I_8(id));
        features.F4ActNE3PHJY9a0_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var QNvnEdnVCcsftf_query;
                    QNvnEdnVCcsftf_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FnPuTavsx1H4H3I_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.5$Fk4AqacuMr7mstart",id);
                    var xajFVDOpHfnwOj_query;
                    xajFVDOpHfnwOj_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FnPuTavsx1H4H3I_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$Fk4AqacuMr7mend",id);
                    var dAMyhUtigAsuQQ_query;
                    dAMyhUtigAsuQQ_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FnPuTavsx1H4H3I_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.5$bmOUNP7TRGj9start",id);
                    var FxAzeNkgxaWhkM_query;
                    FxAzeNkgxaWhkM_query=qCompressed(1.0,"%B5$QueryM5Sa$entityTypeBa$EntityTypeS6$VERTEXSb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FnPuTavsx1H4H3I_8wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.3$bmOUNP7TRGj9end",id);
                    var viHUzeTobxBnKq_query;
                    viHUzeTobxBnKq_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    var siwmrkrPEdLLGd_query;
                    siwmrkrPEdLLGd_query=qCompressed(1.0,"&57f$eJydUl13ojAU/DPZR3sM8vmIEJBuQQxZXPvCAYk1qwLyUbW/foPUSu22u2cfyIFw78ydmfttLIFZQ8uTKwVQACmr4l3Cnpq4ZnlmxnWsQ1f4+IecChqogEz96cPUXvBXmtWsZrTSZV0whhwtASkt2TNNrTLftTd42GJhGMARmGLHdjz9ITKRjzwTecYi0EBesieWxdvqFSLuUE8t2zgG6O0jEAEybcQ51qyq8/L0Oo+BkU6cqcd/5AUtz6M66VgATqpzXngnA8uMX7YjcWb5i/Ce/ozUAyvptODs+9aGM1AKgu+IGJMIecQhi4CCakPr5bobwEmDZQuvzw7EMYPl6ixOwSrWcIwTnGKKVxgOeZW1nB4fv7sG2ngv1wqDdsNowGKGHKDtXsKiOmn8SM0LdKzLJqWYcvXBHPkkapV+bFaAlfkNiZ+rI5yIk5ETqWxXlCyreasCHNfHjkdM2FmJRX7KlwSwhGUdYiheYHkDq4I6LmvCBUANn83U/RtuDFttkGJh2IPlpz7qAsYChzQ0Ho+lG+jSpPXEtPf9ZehG+dxB9CPfFTP3fkPkNa8Q4h4oFpK/QV3cGsAhsIgkEw+p7oGEVm1G6pUlPCjs1y7NQlma91iu3SqwHs09roOkUOfVStmfu4XkhmkgKHcKzzXJ8y2Ns7wYdy/cAA3wOBAOkEE+GmoO4B8MfZ+X+IWy/LQRGHTTOcmKh3UkXJVB+XRi4bg6Bppx47IoX8tcnIwzait8ebQvyrKCPq+ZHfopus2sX7ZvLNSIj/EyMe2rnYJk3Vhqq2LYhLZK1z7Jykh8W7vz9ghLPFr2GEYrziAO/2Udhc49LME+fbvb0oi3SOL/I2Mpbie7yR0qdwNB408MPod6t7/d7W/boadm",id);
                    annotation { "Feature Name" : "#featureName" }
                    hole(context, id + "F4ActNE3PHJY9a0_8", { "isV2" : true, "holeVersion" : HoleVersion.V3, "initEntities" : qUnion([]), "featureName" : "Ø #holeDiameterV3 ↧ #holeDepthV3", "threadStandard" : ThreadStandard.UNSET, "hasClearance" : false, "unitsSystem" : UnitsSystem.METRIC, "styleV2" : HoleStyle.SIMPLE, "style" : HoleStyle.SIMPLE, "locations" : qUnion([QNvnEdnVCcsftf_query, xajFVDOpHfnwOj_query, dAMyhUtigAsuQQ_query, FxAzeNkgxaWhkM_query]), "scope" : qUnion([viHUzeTobxBnKq_query]), "ansiHoleTableEx" : lookupTablePath({ "size" : "1/4 (0.25)", "holeType" : "Drilled" }), "ansiHoleTable" : lookupTablePath({ "size" : "1/4 (0.25)", "holeType" : "Drilled" }), "isoHoleTableEx" : lookupTablePath({ "fit" : "Normal", "size" : "M3.5", "holeType" : "Clearance" }), "isoHoleTable" : lookupTablePath({ "fit" : "Close", "size" : "M3.5", "holeType" : "Clearance" }), "showThreadClassV2" : false, "ansiThreadClassV2" : lookupTablePath({ "class" : "2B" }), "isoThreadClassV2" : lookupTablePath({ "class" : "6H" }), "showTappedDepth" : false, "holeDiameterV3" : { 'value' : try(2 * millimeter), 'expression' : "2 mm" }.value, "tapDrillDiameterV3" : { 'value' : try(3.75 * millimeter), 'expression' : "3.75 mm" }.value, "holeDiameterV2" : 2.0 * millimeter, "holeDiameterV2Precision" : PrecisionType.DEFAULT, "holeDiameterV2ToleranceType" : ToleranceTypeExtended.NONE, "holeDiameterV2ToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2ToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2ToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterV2ToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2ToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterV2FitToleranceTable" : lookupTablePath({ "fit" : "User defined", "standard" : "ISO", "shaftClass" : "None", "holeClass" : "A9" }), "holeDiameterV2holeClassToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterV2holeClassToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tapDrillDiameterV2" : { 'value' : try(3.75 * millimeter), 'expression' : "3.75 mm" }.value, "tapDrillDiameterV2Precision" : PrecisionType.DEFAULT, "tapDrillDiameterV2ToleranceType" : ToleranceType.NONE, "tapDrillDiameterV2ToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterV2ToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "startStyle" : HoleStartStyle.PLANE, "startBoundEntity" : qUnion([siwmrkrPEdLLGd_query]), "endStyleV2" : HoleEndStyleV2.BLIND, "endStyle" : HoleEndStyle.BLIND, "oppositeDirection" : false, "endBoundEntity" : qUnion([]), "offset" : false, "offsetDistance" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeOffsetDirection" : false, "standardTappedOrClearance" : lookupTablePath({ "standard" : "Custom" }), "standardBlindInLast" : lookupTablePath({ "standard" : "Custom" }), "showThreadClass" : false, "ansiThreadClass" : lookupTablePath({ "class" : "2B" }), "isoThreadClass" : lookupTablePath({ "class" : "6H" }), "holeDiameter" : 2.0 * millimeter, "holeDiameterPrecision" : PrecisionType.DEFAULT, "holeDiameterToleranceType" : ToleranceTypeExtended.NONE, "holeDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDiameterFitToleranceTable" : lookupTablePath({ "fit" : "User defined", "standard" : "ISO", "shaftClass" : "None", "holeClass" : "A9" }), "holeDiameterholeClassToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDiameterholeClassToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDiameterV3" : { 'value' : try(7.375 * millimeter), 'expression' : "7.375 mm" }.value, "cBoreDepthV3" : { 'value' : try(3.5 * millimeter), 'expression' : "3.5 mm" }.value, "cBoreDiameter" : { 'value' : try(7.375 * millimeter), 'expression' : "7.375 mm" }.value, "cBoreDiameterPrecision" : PrecisionType.DEFAULT, "cBoreDiameterToleranceType" : ToleranceType.NONE, "cBoreDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDepth" : { 'value' : try(3.5 * millimeter), 'expression' : "3.5 mm" }.value, "cBoreDepthPrecision" : PrecisionType.DEFAULT, "cBoreDepthToleranceType" : ToleranceType.NONE, "cBoreDepthToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDepthToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDepthToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cBoreDepthToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cBoreDepthToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cSinkDiameterV3" : { 'value' : try(7.84 * millimeter), 'expression' : "7.84 mm" }.value, "cSinkAngleV3" : { 'value' : try(90 * degree), 'expression' : "90 degree" }.value, "cSinkDiameter" : { 'value' : try(7.84 * millimeter), 'expression' : "7.84 mm" }.value, "cSinkDiameterPrecision" : PrecisionType.DEFAULT, "cSinkDiameterToleranceType" : ToleranceType.NONE, "cSinkDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cSinkDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cSinkDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cSinkDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "cSinkDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "cSinkAngle" : { 'value' : try(90 * degree), 'expression' : "90 degree" }.value, "cSinkAnglePrecision" : PrecisionType.DEFAULT, "cSinkAngleToleranceType" : ToleranceType.NONE, "cSinkAngleToleranceBoundSymmetrical" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "cSinkAngleToleranceBoundDeviationUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "cSinkAngleToleranceBoundDeviationLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "cSinkAngleToleranceBoundLimitsUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "cSinkAngleToleranceBoundLimitsLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "tapDrillDiameter" : { 'value' : try(3.75 * millimeter), 'expression' : "3.75 mm" }.value, "tapDrillDiameterPrecision" : PrecisionType.DEFAULT, "tapDrillDiameterToleranceType" : ToleranceType.NONE, "tapDrillDiameterToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tapDrillDiameterToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tapDrillDiameterToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "majorDiameter" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "isMultiple" : false, "holeDepthMultiple" : "Multiple", "holeDepthMultiplePrecision" : PrecisionType.DEFAULT, "holeDepthMultipleToleranceType" : ToleranceType.NONE, "holeDepthMultipleToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthMultipleToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthMultipleToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthMultipleToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthMultipleToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthComputedV3" : { 'value' : try(12 * millimeter), 'expression' : "12 mm" }.value, "holeDepthComputed" : { 'value' : try(12 * millimeter), 'expression' : "12 mm" }.value, "holeDepthComputedPrecision" : PrecisionType.DEFAULT, "holeDepthComputedToleranceType" : ToleranceType.NONE, "holeDepthComputedToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthComputedToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthComputedToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthComputedToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthComputedToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthV3" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "holeDepth" : 5.0 * millimeter, "holeDepthPrecision" : PrecisionType.DEFAULT, "holeDepthToleranceType" : ToleranceType.NONE, "holeDepthToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "holeDepthToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "holeDepthToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tipAngleStyle" : TipAngleStyle.DEGREE118, "tipAngleV3" : { 'value' : try(118 * degree), 'expression' : "118 deg" }.value, "tipAngle" : { 'value' : try(118 * degree), 'expression' : "118 deg" }.value, "tipAnglePrecision" : PrecisionType.DEFAULT, "tipAngleToleranceType" : ToleranceType.NONE, "tipAngleToleranceBoundSymmetrical" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "tipAngleToleranceBoundDeviationUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "tipAngleToleranceBoundDeviationLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "tipAngleToleranceBoundLimitsUpper" : { 'value' : try(1 * degree), 'expression' : "1 deg" }.value, "tipAngleToleranceBoundLimitsLower" : { 'value' : try(-1 * degree), 'expression' : "-1 deg" }.value, "isTappedThrough" : true, "tappedDepthV3" : { 'value' : try(6.9 * millimeter), 'expression' : "6.9 mm" }.value, "tappedDepth" : { 'value' : try(6.9 * millimeter), 'expression' : "6.9 mm" }.value, "tappedDepthPrecision" : PrecisionType.DEFAULT, "tappedDepthToleranceType" : ToleranceType.NONE, "tappedDepthToleranceBoundSymmetrical" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tappedDepthToleranceBoundDeviationUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tappedDepthToleranceBoundDeviationLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tappedDepthToleranceBoundLimitsUpper" : { 'value' : try(0.1 * millimeter), 'expression' : "0.1 mm" }.value, "tappedDepthToleranceBoundLimitsLower" : { 'value' : try(-0.1 * millimeter), 'expression' : "-0.1 mm" }.value, "tappedAngle" : { 'value' : try(1.789911 * degree), 'expression' : "1.789911 deg" }.value, "tapClearance" : { 'value' : try(3), 'expression' : "3" }.value, "toleranceMatching" : { 'value' : try({ "cBoreDepth" : "cBoreDepthV3", "cBoreDiameter" : "cBoreDiameterV3", "cSinkAngle" : "cSinkAngleV3", "cSinkDiameter" : "cSinkDiameterV3", "holeDepth" : "holeDepthV3", "holeDepthComputed" : "holeDepthComputedV3", "holeDiameter" : "holeDiameterV2", "holeDiameterV2" : "holeDiameterV3", "tapDrillDiameter" : "tapDrillDiameterV2", "tapDrillDiameterV2" : "tapDrillDiameterV3", "tappedDepth" : "tappedDepthV3", "tipAngle" : "tipAngleV3" }), 'expression' : "{\"cBoreDepth\" : \"cBoreDepthV3\", \"cBoreDiameter\" : \"cBoreDiameterV3\", \"cSinkAngle\" : \"cSinkAngleV3\", \"cSinkDiameter\" : \"cSinkDiameterV3\", \"holeDepth\" : \"holeDepthV3\", \"holeDepthComputed\" : \"holeDepthComputedV3\", \"holeDiameter\" : \"holeDiameterV2\", \"holeDiameterV2\" : \"holeDiameterV3\", \"tapDrillDiameter\" : \"tapDrillDiameterV2\", \"tapDrillDiameterV2\" : \"tapDrillDiameterV3\", \"tappedDepth\" : \"tappedDepthV3\", \"tipAngle\" : \"tipAngleV3\"}" }.value, "asVersion" : FeatureScriptVersionNumber.V2985_SWEEP_TWIST_FIXES });
                }
            };
        try(features.F4ActNE3PHJY9a0_8(id));
        features.Fs0xZNFKzZAG8b7_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var FuNqRMogWKUrDP_query;
                    FuNqRMogWKUrDP_query=qCompressed(1.0,"&1c8$eJx1UE1Pg0AQ/TPj1bhIKRxhWZBYKM6SmnohC2zKpgp0WbT8e0ubeDE9zsyb9/UQrOBtknpOHU4saNQovip1mIRRfRcKI3ySWv8vxTxITp5hi0mcZP6mDFnOspBldM896LU6qE58jr5Nn9IVFyA7o8y8fAUC2N/AbWBhzHgFrRpNr29LFygyv0i22eXQD1JfJZMmsCBpfMIJeXQg6uejpUjavBfdsGlL60dpuR0u6qclzpWoAf7KCvpSsqxIij2XMB6lqdubgaThNRBnntUuGM/co4tXtHGFDq7RRYEV1riAUqyCTsZrg9K7C+oG+d2qeJc3jNwFnaaITfaHqKswRps6lwIin7IFx9egRm6ENhG6tLrl9CCKXXs37WJXtnnR6dLuB3Y2emokVktTfl4uDL8/YpSJ",id);
                    var gUMsTtZQQMerfV_query;
                    gUMsTtZQQMerfV_query=qCompressed(1.0,"&1c8$eJx1UE1TgzAQ/TPx6hikUI4QAs1YaN0wdeqFCSRTYi2hEFT+vaWd8eL0uLtv39dDtECvo+qnzOPYQVIP4lTpwyisNm0srAhx5vy/FFOnOH5GG2Apy8N1GdMtzWOakz0PkOn1Qbficwhd8pQtuECqtdpO81ckEP0buItonFJeoUYP1vS35RIRoGHBNvnlYDrVXyWZjBzEZIg5xo8eSsx0dDTO5FvRduumdL51rzbdRf08x7kSScRfaEFWJc0LVuy5QsNR2bq5GWCS1wh706R30fDDAzJ7BRcW4IEPSxBQQQ0zKIMqalXqW1DBXVDbqa9Gp7utpPgu6DwmdHTfRV3FKbjEuxSQhITOOO4jPXArepvAklS3nAFKPlzwI2aNWZ1W07Z0TEd/bD9KBdXcVLgtZ4ZfROOUrQ==",id);
                    annotation { "Feature Name" : "Plane 1" }
                    cPlane(context, id + "Fs0xZNFKzZAG8b7_8", { "entities" : qUnion([FuNqRMogWKUrDP_query, gUMsTtZQQMerfV_query]), "cplaneType" : CPlaneType.MID_PLANE, "offset" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "angle" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "oppositeDirection" : false, "flipAlignment" : false, "flipNormal" : false, "width" : { 'value' : try(150 * millimeter), 'expression' : "150 mm" }.value, "height" : { 'value' : try(150 * millimeter), 'expression' : "150 mm" }.value, "asVersion" : FeatureScriptVersionNumber.V3044_SWEEP_EXTEND_OPTION_REVERT });
                }
            };
        try(features.Fs0xZNFKzZAG8b7_8(id));
        features.FpcGW5gFQbiM221_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var iArHYIfBGqzfPw_query;
                    iArHYIfBGqzfPw_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    var iXiGGOSiwVqHHz_query;
                    iXiGGOSiwVqHHz_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.7$Fs0xZNFKzZAG8b7_8planeOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Split 4" }
                    splitPart(context, id + "FpcGW5gFQbiM221_8", { "splitType" : SplitType.PART, "targets" : qUnion([iArHYIfBGqzfPw_query]), "tool" : qUnion([iXiGGOSiwVqHHz_query]), "keepTools" : true, "useTrimmed" : false, "keepBothSides" : false, "keepFront" : true, "faceTargets" : qUnion([]), "faceTools" : qUnion([]), "projectionType" : ProjectionType.DIRECTION, "useSketchPlaneDirection" : true, "directionQuery" : qUnion([]), "keepToolSurfaces" : true, "asVersion" : FeatureScriptVersionNumber.V3044_SWEEP_EXTEND_OPTION_REVERT });
                }
            };
        try(features.FpcGW5gFQbiM221_8(id));
        features.FBlfhAZZzqj2tb6_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var IuUmiErQLZjsZG_query;
                    IuUmiErQLZjsZG_query=qCompressed(1.0,"&209$eJx1kU1zgjAQhv9Meu0QQZQjHwGxCjZhtHhhgmQwUPkIoNJfX5CZXjocd/fZfd/dfTOW4LNjot8vCVyAhDf0FvO0oy0vC4u2VIf7xf9K0FeMQBn42HVcT99FFjogz0KeGRINlIKnvKDfja6a0jCYAla0vO3HLoMC9BcQBSDLQSQGV960pZiSa2BipAeu7w2FsmLiJekmxgK4iQ4JhO8qsL1aNHfn6Oylcx5bkfzggvnVoF6P67wGJYB8oMDcRMgL3CAkDDQ5ay/XyYCbkAswTW9d2w5LbrU9esUKXmIVr/AaUxzjCx6hx7Em9yCzCyFps5CsQDd9hFnV735moSTPKulYGGXTP2chdpKyK9YZYm04L3emt54a7Cu2N1gx1eGUhm+FE2fG05k0YHdpQ+FGU3O+2m5XkVxW6NmKLmE4Hv5CTugQRGPjL73GqQQ=",id);
                    var sIpSeDaVMIhRAr_query;
                    sIpSeDaVMIhRAr_query=qCompressed(1.0,"&208$eJx1UF2PmzAQ/DPb16qmIYRHPgyxGj5ujS5KX5DBVuLeBfvAXI9/X5JIlarqHnd2ZndmvsQ+PM1qXAqfdyDVqN+VzEZzTb6tCPFA6klcO32ehdNmSIUTESm8/zfNYhUn36FClrMyOrQprWmZ0jI58RDMqM96EK9TtLkfFqAGp91yU8UC6N+Bb4CmOV29XPTkzPgAd5AgjRpWlevCWDXeXzIZe8BkRDghX7eQmeXF06SQx2awh0vr/dajquz6/e0W8H5IAv9Bm2Tf0rJhzYkrmF6U6y8PA0zyHsh2WfRzPH3wMLl5RR+3GOAOQ+ywR4lqJRXYxYPKA4cq/JQ0WPV+0flzLSn5lPQ2Z3Te/BR9l+boJ8FaQFylpwcv6R/hQsh+bTCImTNmf90vdesZSz/cOEuF/domP9K6ae9CH4n4Vx1AZvv86J+zp04Xnkfa3WRftavsqvWB1wfW/AG4MajA",id);
                    var GjCQbdjoHWCLrT_query;
                    GjCQbdjoHWCLrT_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.7$Fs0xZNFKzZAG8b7_8planeOpS9$queryTypeS5$DUMMY",id);
                    var QiFxseTXPTKaCW_query;
                    QiFxseTXPTKaCW_query=qCompressed(1.0,"&208$eJx1UF2PmzAQ/DPb16qmIYRHPgyxGj5ujS5KX5DBVuLeBfvAXI9/X5JIlarqHnd2ZndmvsQ+PM1qXAqfdyDVqN+VzEZzTb6tCPFA6klcO32ehdNmSIUTESm8/zfNYhUn36FClrMyOrQprWmZ0jI58RDMqM96EK9TtLkfFqAGp91yU8UC6N+Bb4CmOV29XPTkzPgAd5AgjRpWlevCWDXeXzIZe8BkRDghX7eQmeXF06SQx2awh0vr/dajquz6/e0W8H5IAv9Bm2Tf0rJhzYkrmF6U6y8PA0zyHsh2WfRzPH3wMLl5RR+3GOAOQ+ywR4lqJRXYxYPKA4cq/JQ0WPV+0flzLSn5lPQ2Z3Te/BR9l+boJ8FaQFylpwcv6R/hQsh+bTCImTNmf90vdesZSz/cOEuF/domP9K6ae9CH4n4Vx1AZvv86J+zp04Xnkfa3WRftavsqvWB1wfW/AG4MajA",id);
                    annotation { "Feature Name" : "Mirror 3" }
                    mirror(context, id + "FBlfhAZZzqj2tb6_8", { "patternType" : MirrorType.PART, "operationType" : NewBodyOperationType.NEW, "entities" : qUnion([IuUmiErQLZjsZG_query, sIpSeDaVMIhRAr_query]), "faces" : qUnion([]), "instanceFunction" : try(featureList({})), "mirrorPlane" : qUnion([GjCQbdjoHWCLrT_query]), "defaultScope" : false, "booleanScope" : qUnion([QiFxseTXPTKaCW_query]), "fullFeaturePattern" : false, "asVersion" : FeatureScriptVersionNumber.V3044_SWEEP_EXTEND_OPTION_REVERT });
                }
            };
        try(features.FBlfhAZZzqj2tb6_8(id));
        features.FDfgOL6tis0JrqL_8 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var MduSambHKjqXWw_query;
                    MduSambHKjqXWw_query=qCompressed(1.0,"&259$eJx1UdtuozAU/Bn3dVWzXMIjF0NQw6U2apS8IIO9wW2CHTDdsl9fh0iVqlVfLB2fmTlz5jyEDnie+bjkLmkB46N45ywZ5SV6zB38eHsJtAATE7204jRTLeQQU00DmFv/d+pFcQJ/gxJnaVYEuyZGFSpiVEQH4gM5ipMY6HkK7FWYAj5ooZcbK6QAfRXEBihOkXHUi0nL8f65ARFGQZ2VhWlIxcd1ZMZCC2QsgATCXy5I5PJmCZizfT2oXd9Yf8XIS2WmX29rrkIMkCdUR9sGFXVWHwgH0xvXXX83kDHSAegui3gJpw/iR2sUDnaxhzfYxy3uMMPcgHLchgNPPY25/yNoUPy9F+lLxRD8EXSdEzTbR9q1cYqdyDMBhGV8uOOi7r6cD5JXG3thpqXcXrZL1VhSoQ89zozjzqRJ9qiqm5XoYEi/sz2QqC7dO6fkuRW5ZcFmM6mz0KUyXAeQapfVXzRjSQyTpkPHC3oxJwXwm4/w/KcPjsd/11dLt26zkaqiWvNxMFo2iMrq8AkuDsJb",id);
                    var GXpkTussJYhFrc_query;
                    GXpkTussJYhFrc_query=qCompressed(1.0,"&208$eJx1UF2PmzAQ/DPb16qmIYRHPgyxGj5ujS5KX5DBVuLeBfvAXI9/X5JIlarqHnd2ZndmvsQ+PM1qXAqfdyDVqN+VzEZzTb6tCPFA6klcO32ehdNmSIUTESm8/zfNYhUn36FClrMyOrQprWmZ0jI58RDMqM96EK9TtLkfFqAGp91yU8UC6N+Bb4CmOV29XPTkzPgAd5AgjRpWlevCWDXeXzIZe8BkRDghX7eQmeXF06SQx2awh0vr/dajquz6/e0W8H5IAv9Bm2Tf0rJhzYkrmF6U6y8PA0zyHsh2WfRzPH3wMLl5RR+3GOAOQ+ywR4lqJRXYxYPKA4cq/JQ0WPV+0flzLSn5lPQ2Z3Te/BR9l+boJ8FaQFylpwcv6R/hQsh+bTCImTNmf90vdesZSz/cOEuF/domP9K6ae9CH4n4Vx1AZvv86J+zp04Xnkfa3WRftavsqvWB1wfW/AG4MajA",id);
                    annotation { "Feature Name" : "Boolean 1" }
                    booleanBodies(context, id + "FDfgOL6tis0JrqL_8", { "operationType" : BooleanOperationType.UNION, "tools" : qUnion([MduSambHKjqXWw_query, GXpkTussJYhFrc_query]), "targets" : qUnion([]), "offset" : false, "offsetAll" : false, "entitiesToOffset" : qUnion([]), "offsetDistance" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "oppositeDirection" : false, "reFillet" : false, "keepTools" : false, "asVersion" : FeatureScriptVersionNumber.V3044_SWEEP_EXTEND_OPTION_REVERT });
                }
            };
        try(features.FDfgOL6tis0JrqL_8(id));
        return context;
        features.FGAY78YQvYy5eKm_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var aqiqAENZqSvBGZ_query;
                    aqiqAENZqSvBGZ_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6$sM9vLHW55aICbottomC0M5R4R5R6R7R8RaRbRcRdS-12.5$rightR4C6S6$VERTEXR6R7S7$isStartFR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                    var FZDSrymGIoonpK_query;
                    FZDSrymGIoonpK_query=qCompressed(1.0,"%B5$QueryM6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA2C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$F3HD5PxY3AAr9PG_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc.6$sM9vLHW55aICbottomC0M5R4R5R6R7R8RaRbRcRdS-12.5$rightR4C6S6$VERTEXR6R7S7$isStartTR8CbA1S11.9$FMFhDfYjq2jKuAM_0opExtrudeRbSa$CAP_VERTEX",id);
                    annotation { "Feature Name" : "Plane 2" }
                    cPlane(context, id + "FGAY78YQvYy5eKm_7", { "entities" : qUnion([aqiqAENZqSvBGZ_query, FZDSrymGIoonpK_query]), "cplaneType" : CPlaneType.MID_PLANE, "offset" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "angle" : { 'value' : try(0 * degree), 'expression' : "0 deg" }.value, "oppositeDirection" : false, "flipAlignment" : false, "flipNormal" : false, "width" : { 'value' : try(150 * millimeter), 'expression' : "150 mm" }.value, "height" : { 'value' : try(150 * millimeter), 'expression' : "150 mm" }.value, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FGAY78YQvYy5eKm_7(id));
        features.FtlTo90XX56P5qa_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var EBGxcMdlQPUWAo_query;
                    EBGxcMdlQPUWAo_query=qCompressed(1.0,"&1bf$eJx1kE9zgjAQxb9Meu00FFGO/ImYqYDdMDr2wgSSkdRKEEIr374gM710PO7ub9++t0/+Ar33sh3iBcMWEqrjl0Kdem6UrkNuuIdj6/8kGxrJ8CtKgUY08bZ5SHYkCUkSHJmLdKtOquZfnWcHL6MwR7I2ygzTls8R+SuYjUgYEVagSnVGt3NzhQIgXkbTZBzoRrb3k1T4FqLCwwzjZwet9XC2FI7FIaubbZVbP6qVaTNev05x7kICsTeSBZucJBnNjkyi7ixNWc0GqGAlws4wqL3f3ZgbTF7BhgU4sIQVcCighAmKofBrGS0NSPchVDfyu1LRficIfghd+zXp7Q9eFmEEduCMD/DT8DhzQTGHc9H604alT43Wm8tm2OWWbsjNtL2QUIzfZAeyy/Jp8RcLNpH0",id);
                    var rbeeeIEuDuVhrv_query;
                    rbeeeIEuDuVhrv_query=qCompressed(1.0,"%B5$QueryM4Sa$entityTypeBa$EntityTypeS4$FACESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.7$FGAY78YQvYy5eKm_7planeOpS9$queryTypeS5$DUMMY",id);
                    annotation { "Feature Name" : "Split 1" }
                    splitPart(context, id + "FtlTo90XX56P5qa_7", { "splitType" : SplitType.PART, "targets" : qUnion([EBGxcMdlQPUWAo_query]), "tool" : qUnion([rbeeeIEuDuVhrv_query]), "keepTools" : true, "useTrimmed" : false, "keepBothSides" : true, "keepFront" : true, "faceTargets" : qUnion([]), "faceTools" : qUnion([]), "projectionType" : ProjectionType.DIRECTION, "useSketchPlaneDirection" : true, "directionQuery" : qUnion([]), "keepToolSurfaces" : true, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FtlTo90XX56P5qa_7(id));
        features.FdNaoPo25npL0V6_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var gBqFWkSsvnyIPj_query;
                    gBqFWkSsvnyIPj_query=qCompressed(1.0,"&21a$eJx1UU1TgzAQ/TPx6hgsIEcCgWYsHyaZar0wgWRsbEsoBJV/L7QzenA87u57b9/bvUEueBpVP2Ueq4FUvf5QMunNKbrLXAYdIPUgTrV+G4XVpo2FFSHMnL8TPnWKwXtQUJKSPNxUMS5xHuM82rEAmF6/6VYch3B1ERZAtVbbaWEhAfBPwVYAxymevez1YE1/bT6AiOKQkyKfB6ZT/WUlkcgBRIaQQXjrgcRMB0fDTD7zttvsK+dT96ro5u3nJeBFSAL2iHm0rnDOCd8xBYaDss3+aoBI1gDoTZPeouGLBdHilbrUoz59oAGtaUMlVTMoozVqVepbqoJ/QW2nPvY63ZYSw39B5zHB4+pVNHWcUjfy5wOgIt5dcVFzDReA5H1FfUSsMevTeiorx3T4y/ajVLSZr8meccmrC9GlUCzsOZselk8i0RyQkRP/1fNBYo/cBHcvL65XumdR+UN31LboZjUXsHJD+DcPUK+M",id);
                    var LkWqdlHOGeTcxZ_query;
                    LkWqdlHOGeTcxZ_query=qCompressed(1.0,"&1340$eJy1mFt3sjoQhv9M9mW7SMJBLjkpqAgGrOKNi0NUPIGIVv31O2p3P9uq9Vu61+oFHZJn3plMJsR/VAG017TY2aIXgYQW6YYm1SKbKyjSOFvwIAJJugrnUTpah2WaLfSwDBVko59v/F1OPYiBQ6ya1VKaA91wjZZutLTAk0FWpKN0Ec5WCjyCQ0AXZVruDrPUEBif/3g8MPSaweSM01WZFSdjBWjEUHzLabEXWU6Lo0srURGwEgV6EL6KoIpNXXC3AVaUQnZrA/yeFtTJmfflIcYjKAFew/A1c2C0fMsPPApWU1rG45MAK/FiBlrZ8qZpdgUhtLQoK8tsbiPCHZWLhCOQ/SmQmRDT5Tuu03RqAXs8RpTSlYIUdAiSTUFs8PFRICKRSIXIJCIxSQj1XiB+5cGMDksiaJIngjeD+EbvNEqLWVAvyasE0nlepIuSxCwMq+UbxDM0X3+B97iIQbyZ7+WRuNx7TLlAYOVjBAzZEBjp8GzWweZJwLJdwhyx4IbAJx3jbB2PQnlQVTTjTCbLvQyqdnWsD4PJEk0aa8UecFlubMtinVAGDYHXNVx/cJh4lAoPqtGVpBKICeTvT6IAWG2NywvhEYTvSxPajz0XybYqaNwlDky+5YmgChOKImZG9MOOOWbH8CPAUyiY8KeCv6IdgzLL74IQzN85Tn5EVAwmpD6q8pMF3JKHwouBjWXcif2h4qTrx0hpKK3Vpj4NxbfhYyR1vfe4OhraXUgeI9WCqRWnG9/sj7nHSO8U7lMOlfLI6d63xuhBj9Mdvxh3YBDb/fZjpLGczuvr/M3c1uljJC/BnUCZzUfp3nuElLxWgKWM26aQJ3EvCzk7LYqs0G5A0R3QFyyAGMYrix0yHbnNc1+6l8zf6F4yf5Mqz983lf6uiSUlv9J97oel24rjtYtpbUvJRRjCf93KmFPx/mgr9PD+t2b8SxhY5XvjreWJUej8Dx2ZhMljJXbQSCvLEbetr3WS7B/ajydcvXTeS533NyY3fwLOzLnNm2vsyZwBH8f1rcIutt4+3jY7T8CVwV4wNr2tPNl1n4AzzMnCT71cmWebJ+Boy01b7zBYNCh+Aq7RbEltdVNZ9aTeE3BBD8XvdUduC6Z4H47ITyj35lhDE9sIoklQu+KW9YYfUPQV+t8X4wsF1bS2mige3xC5SjiMB9yfr9aoadszX8+Xe/2bpiH9HCWO4nrPKclwZU8v6PneoghGv0Z8Ru84nNyd+D1RfFtdov8xnX0ELyniGmiojlzdFIYDnOVqls1ouGAfwQLw3KblX0nTDSVeZuW7oTtrCMv973H+vqxnaB3b9XjiUrPvXDq9z00QwkPnhX+VxGptWxjavi8Lk+XVkmFQ+XsQ7HYgX/N+ui2IP9aXD2/N+qqZHWBc5bpumyy8ld7kphJHrtdvtpuiFNpJ11/kzfEAfU6H4m6XvqmrrSdr35xALHwOW66rxprvh3Gk1y7UUwVUtUk7oC2tt4/s/jof8FleTWczWh7vVGqTXcvO71Rn4d2oJjOqxpV5QGlLYqlhJymWbmi0SaQuaE0qCf2aWnxAQjz8ONHZGnCHVA8vdB/m4UJ4LwiD6oQnkmqVWWbOzZ17TOHFvfUisN2FVFXg9KnfyNwJFQf4uKlsg9QuJIA5xdeTkJudaUT8yHj3xBvBL3K6Gae1NzcxDlHIl4SJAqia+XzbwE5Xs3YkywbSWWa+ieJZuQrMyrNnQfqSUCH+ktAL++w49a5+/53NJz/3s3DcGwK65Y/Jvc8fzz/FH8Z3+vt6yb3p79PoUZCuDj9uqWE8VbNk5/9ZRglUy5mfyVyvJ4iusAwH0iqfpaWTsyKD0ql1D7wOOWy3wefvMP8Ciz1ubA==",id);
                    var nhULTsmucamjop_query;
                    nhULTsmucamjop_query=qCompressed(1.0,"&21a$eJx1UU1TgzAQ/TPx6hgsIEcCgWYsHyaZar0wgWRsbEsoBJV/L7QzenA87u57b9/bvUEueBpVP2Ueq4FUvf5QMunNKbrLXAYdIPUgTrV+G4XVpo2FFSHMnL8TPnWKwXtQUJKSPNxUMS5xHuM82rEAmF6/6VYch3B1ERZAtVbbaWEhAfBPwVYAxymevez1YE1/bT6AiOKQkyKfB6ZT/WUlkcgBRIaQQXjrgcRMB0fDTD7zttvsK+dT96ro5u3nJeBFSAL2iHm0rnDOCd8xBYaDss3+aoBI1gDoTZPeouGLBdHilbrUoz59oAGtaUMlVTMoozVqVepbqoJ/QW2nPvY63ZYSw39B5zHB4+pVNHWcUjfy5wOgIt5dcVFzDReA5H1FfUSsMevTeiorx3T4y/ajVLSZr8meccmrC9GlUCzsOZselk8i0RyQkRP/1fNBYo/cBHcvL65XumdR+UN31LboZjUXsHJD+DcPUK+M",id);
                    annotation { "Feature Name" : "Mirror 2" }
                    mirror(context, id + "FdNaoPo25npL0V6_7", { "patternType" : MirrorType.PART, "operationType" : NewBodyOperationType.ADD, "entities" : qUnion([gBqFWkSsvnyIPj_query]), "faces" : qUnion([]), "instanceFunction" : try(featureList({})), "mirrorPlane" : qUnion([LkWqdlHOGeTcxZ_query]), "defaultScope" : false, "booleanScope" : qUnion([nhULTsmucamjop_query]), "fullFeaturePattern" : false, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FdNaoPo25npL0V6_7(id));
        features.FDpNRkj10ovToDE_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var lLNlSQODNwRqnu_query;
                    lLNlSQODNwRqnu_query=qCompressed(1.0,"&2c0$eJx9kltvozAQhf+M93WFgdDyyMUQ2gJZG6VLXpAJLnFYbsa50F9fk2hXWlXKozVnvnPGMz/cFfh1YmKOLVKCigl+ZlUg+tbRCAWsk1zO2TwwlwL070FM4KZ+TmzwoZRZ3/+ZHN3T4hWBOqj4RNuS1ycqed/5VFIHxvr3yg0EDZDiKIwS563w0QYlPkq8BdwLXvOOKrC1gLHuGcoV+SFSMQ98kr24R3kGHkZOFqWJKvQDEzd4VLk6iCoHEgh/WiBIRjGdw20Ya7um9AvjwgVLB+UzLrPfQBUgryjz1gVKsijLCQNTw+T+cB87qsgeeF7yPAYhq9oxuKfCNqa4xHvM8AeGGoZQyS7bkZyzY9AJzX4gM0wY1Zf8OMxvnw9kVXMctG3n9tN8fSBj79rxgB2GmMwfme5oO1OX/S6DtZIYd4nH7j9lg+BUTxSubavhTy8vT4XRD+gqxalSEHUQ5B1tsmJZvvKwsIZ18y9FwXk3SdrtWUJbtVoA/wNfW6dzczS6jIq0K1b9sKFSMtEpsAm8dJN/y/LZ7My6SYl/bJpXb2lx1a0xurSsQIxwiL4AQnjkFw==",id);
                    var XHYniXMWnDwCbl_query;
                    XHYniXMWnDwCbl_query=qCompressed(1.0,"%B5$QueryM6Sb$derivedFromA0Sa$entityTypeBa$EntityTypeS4$FACES9$fromToolsA2C0M5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5R2C3S4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$dkjp0VnBosyxR2R3RaRbRcCeA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRfSa$SWEPT_FACEC0M6R0R1aR2R3RaRbSc$instanceNameS1$1RcCeA1S11.9$FxmAnBYEqBearOn_5opPatternRfS4$COPYRaRbRcCeA1S11.9$FzkZ4gkOSDjkkKC_5opBooleanRfS5$MERGE",id);
                    annotation { "Feature Name" : "Split 2" }
                    splitPart(context, id + "FDpNRkj10ovToDE_7", { "splitType" : SplitType.PART, "targets" : qUnion([lLNlSQODNwRqnu_query]), "tool" : qUnion([XHYniXMWnDwCbl_query]), "keepTools" : true, "useTrimmed" : false, "keepBothSides" : true, "keepFront" : true, "faceTargets" : qUnion([]), "faceTools" : qUnion([]), "projectionType" : ProjectionType.DIRECTION, "useSketchPlaneDirection" : true, "directionQuery" : qUnion([]), "keepToolSurfaces" : true, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FDpNRkj10ovToDE_7(id));
        features.FXlKiGIzo2ATiBE_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var oGsqLnpDyivcuJ_query;
                    oGsqLnpDyivcuJ_query=qCompressed(1.0,"&2fc$eJx9kllvozAUhf+M+zrCkKV5ZDGENoGMjdKSF+QENzEUDMZZ6K8fEzQjjSLl0fI53z13eXGm4PeZyX49JXuQM8kvLPelqFxjPcOGbRAKWK246pO+YQ4F6N+DTIATeylZgC+tT4T47mxT26YEmiDnHa32/Himiovao4racG0+/txB0AIxDoMwsleZhzYo8lDkDmAh+ZHXVINnAxibrqWrIi9AOuyJd0rIMcorcDGykzCO9IdomLzDw9wxQZjbkED4awb8qJXdJdgGa2NX7r3MunLJ4kbXaYcJ3EE5IO8ocZcZipIwSQkDXcnU4TS2HebkAFw3em39gOVV64+p8AJTvMcHzPAXhgaGUMuu25ZcksKvpbF4IrMmMDxe06LpVz9PZHlZNMa2dkTX357I2IdRnLDNEFPps6I7WvXUYZ97f6kl1ihx2TipBfDPx47C5WJW8vnb2zyzRINuSp5zDdEHQT7QJsmG5Y9Xgs3JX4qG87pTtD6wiFZ6tQD+B75Vdu2kqHUYlXGdTUWzoUoxWWvwBLjxJn3I8lPuJscyJl5Rlu/uYHH0rTE6WKZgjXCAHnuYA99rIlwW0BCXRHgom3fNN1dxc3eRzSpM/gCRC/Z9",id);
                    var UonFnxriDQpNnE_query;
                    UonFnxriDQpNnE_query=qCompressed(1.0,"%B5$QueryM6Sb$derivedFromA0Sa$entityTypeBa$EntityTypeS4$FACES9$fromToolsA2C0M5S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5R2C3S4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$3ZamyaBeXbFHR2R3RaRbRcCeA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRfSa$SWEPT_FACEC0M6R0R1aR2R3RaRbSc$instanceNameS1$1RcCeA1S11.9$FxmAnBYEqBearOn_5opPatternRfS4$COPYRaRbRcCeA1S11.9$FzkZ4gkOSDjkkKC_5opBooleanRfS5$MERGE",id);
                    annotation { "Feature Name" : "Split 3" }
                    splitPart(context, id + "FXlKiGIzo2ATiBE_7", { "splitType" : SplitType.PART, "targets" : qUnion([oGsqLnpDyivcuJ_query]), "tool" : qUnion([UonFnxriDQpNnE_query]), "keepTools" : true, "useTrimmed" : false, "keepBothSides" : true, "keepFront" : true, "faceTargets" : qUnion([]), "faceTools" : qUnion([]), "projectionType" : ProjectionType.DIRECTION, "useSketchPlaneDirection" : true, "directionQuery" : qUnion([]), "keepToolSurfaces" : true, "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FXlKiGIzo2ATiBE_7(id));
        features.FmuNYrEQJyxmnHM_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var RELkZxhADcmgRv_query;
                    RELkZxhADcmgRv_query=qCompressed(1.0,"&32b$eJx1UluPojAU/jPdx92ACsgjl4KMCm5L3MEXUqGrBaFQqiP++gFNnEx2fTlJe77LOV/7w9bA7zMV/VrHe5BTwS409wSvHGWtIeVZ9UfF6gTkrCPVnh3ORDJeu0QSS11P/u3EfUOxOgURCvwgtFapCzcwdGHoJNgEXLADq8mps/TRBBNAa8lkP7JsAuDzgGcAuj4cpjuyTnLxuJwDB0ErDqJwaPCGirtlkNsTEOSWilX1lw68sBXdxd/6a2VX7t10+sEEjZrBvR1XvgvlAC9h7CxSGMZBnGAKupLK7PgYIMhxBhwnnLeeT/Oq9e6BaEhHBpojE+1RhnJEB9DHtsWXuPBqoZgvQdOZGhw+kqLpV7eXoLwsGmVb27zrry9B9I9SHJFFIZXJa7sdqXpi0/e9t0CaYwxRepYDRxw2AOuwJEJ6yHSyR2Im8M6HjqgLUy+Z8fZmpFPewKsU55yibMzc2qR3BQ2p9C6TAVZ3ktQZDUk1PDdQv8ldK6u2E9jalIioTjXebIiUVNSD3Aw40SZ5Sn3j3crd7FBG2C3KcumMPJvzEyUDD03m/+EYwHObEJWFqvBLzF2YGl1zYjJqBicN4M0qiL+mpsPy4ye3SVbaPO/jL6Gfk8H+/bRkfnDjEytm9iA1uv79BMO+A4g=",id);
                    var eCMmDlFLocBfJk_query;
                    eCMmDlFLocBfJk_query=qCompressed(1.0,"&340$eJx9kluvojAUhf9M53EmFLwcHykU5KjgtMRz8IVU6dGCUG5e8NdPkcyZTEx8adJ0rW+vvbt/oDH4feZ1t5rQHUh4LS48cWqZW9pqTDR1TohmapQBXrSi7cKu5IgB/H2hI4ACO6Iz8KVcoZSnxtR7M4U6SETD8p04nFkrZGGzlplwpT+/PEDQAAHxXM83l7GN19i3sW/1YFmLgyiYAk8eqXTLUFWx7WIV+SiaVtZDlDdgEWyGXuCrB1ny+gH3EqQDLzEhhfDXBDh+VTcXd+OutG22s2PjKmoelKpO1c/hAUoAXeDQmsfYD70wohw0GW/3x6FtL6F7YFn+W+W4PMkrZ0hFZoSRHdkTTr4I1AiESnbdVPQSpk5Ra7MXMmMEvcM1SstueX8hS7K01DYFkk13eyHjH1p6JCbHvI1eFd2yvGOIf+6cuZIYg8Tiw6RmwDkfGgbns0kmpu/v09iQJb619TlRELUQ9AOvw7j//GFLiD76S1FwUTQtK/bcZ7n6WgD/A99ys0ARrhBndVDEY1muWdvyulDgEbCCdfSU5Z5tR4csoHaaZQurtyC1a5z1ljFYYeLi5x6mwLFLn2Qp1OQllDaOp015Em1QPlx0vfTC78wciKbffMT2GZJJF/7j/NQZcD5PC+F6d6mboUCKpCZp6H8AkjkLnA==",id);
                    annotation { "Feature Name" : "Extrude 10" }
                    extrude(context, id + "FmuNYrEQJyxmnHM_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([RELkZxhADcmgRv_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([eCMmDlFLocBfJk_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FmuNYrEQJyxmnHM_7(id));
        features.FO37YTf58lLS6Z6_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var noTytcpRWvGcQo_query;
                    noTytcpRWvGcQo_query=qCompressed(1.0,"&2de$eJx1Ul3PmjAU/jPd5RZAAbnkoyCvCq4l7tUbUmijBaVYUF/89SuauCWbN01Oz/NxztN+80zw88LksLJwASiT/MpoKMXJ11Ym0l6nhXUDUN6RU8H3F9Jz0QSkJ66+Mv7tZEPLsD4BKYqjOHGXeQDXMAlg4m+xA4Tke96QY+daozwmgDU974eR5REAXwWeAhhEUM114F0v5PNyBnwE3SxOE9UQLZMPy5h6Boipq2Nd/2GBMDnL7hptopW2q4sgn9y4ZGmr3M/jsg8hCvACZv48h0kWZ1vMQFezvjw8B4gpLoHvJ7NzGDF6OoePKExkIRvNkIMKVCKKmALdNmd8zaqwkZrzFjSZ6vH+tq3aYXl/C6J11WqbxhPd8PUWxH5p1QG5DLJ++95uR04D8dhnEc6R6dsqytD14YjDNuAd7onsQ+T45TMxB4SXfUf0uWPV3P74sPOJaOFXLy+UoXLM3F3nDwUT6exp9xf3Xu+m+zrFQVXXCz83ResJcWSkUdwp8NP19j88G4RBm6C60jVxzUQAc7trj7xPW8UyAV4v4+xFU6/Du/FfeqSsPUGH7I/Qd0Nt93lc8Ci+C8PNuKekVBQG+Q39Vurl",id);
                    var dpjfUrexuTxAPq_query;
                    dpjfUrexuTxAPq_query=qCompressed(1.0,"&340$eJx9kluvojAUhf9M53EmFLwcHykU5KjgtMRz8IVU6dGCUG5e8NdPkcyZTEx8adJ0rW+vvbt/oDH4feZ1t5rQHUh4LS48cWqZW9pqTDR1TohmapQBXrSi7cKu5IgB/H2hI4ACO6Iz8KVcoZSnxtR7M4U6SETD8p04nFkrZGGzlplwpT+/PEDQAAHxXM83l7GN19i3sW/1YFmLgyiYAk8eqXTLUFWx7WIV+SiaVtZDlDdgEWyGXuCrB1ny+gH3EqQDLzEhhfDXBDh+VTcXd+OutG22s2PjKmoelKpO1c/hAUoAXeDQmsfYD70wohw0GW/3x6FtL6F7YFn+W+W4PMkrZ0hFZoSRHdkTTr4I1AiESnbdVPQSpk5Ra7MXMmMEvcM1SstueX8hS7K01DYFkk13eyHjH1p6JCbHvI1eFd2yvGOIf+6cuZIYg8Tiw6RmwDkfGgbns0kmpu/v09iQJb619TlRELUQ9AOvw7j//GFLiD76S1FwUTQtK/bcZ7n6WgD/A99ys0ARrhBndVDEY1muWdvyulDgEbCCdfSU5Z5tR4csoHaaZQurtyC1a5z1ljFYYeLi5x6mwLFLn2Qp1OQllDaOp015Em1QPlx0vfTC78wciKbffMT2GZJJF/7j/NQZcD5PC+F6d6mboUCKpCZp6H8AkjkLnA==",id);
                    annotation { "Feature Name" : "Extrude 11" }
                    extrude(context, id + "FO37YTf58lLS6Z6_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([noTytcpRWvGcQo_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([dpjfUrexuTxAPq_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FO37YTf58lLS6Z6_7(id));
        features.FAGoyYN1f6BkQS8_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var BknuTcNTcZTENY_query;
                    BknuTcNTcZTENY_query=qCompressed(1.0,"&2f8$eJx1UluPojAU/jPd1w2ogDxyKcqMgtsSd/GFVNpoQSiUemF+/QAmM5lsfDlJe77LOV/7yzXAnyuT/dbER0CZ5DdGAykqT9saSBuq+axYnwHKO1Id+elKFBe1TxRx9O3s/07SNwzrcxCjcBVGzibz4Q5GPoy8FNtASH7iNbl0jjmaYAJYrbjqR5ZLAPw64AWA/goOc515p4R8Xi6Bh6CThHE0NETD5GQZUncGQuroWNd/myCIWtndVvvVVjuURz+b37lkcTO4t+OykxAF+B0m3jqDURImKWagK5nKz88BQopz4HnRsg1WjFZtMAViIBNZaIlsdEQ5oogNoPu+xbekCGqp2S9B84Uenu5p0fSbj5cgWhaNtq9d0fWPlyD2VyvOyGGQqfS13YFUPXHZv2OwRoZnDVEGjgdHHLYA77AiUgXI9vJnYjYIrqeO6GvbLLn19mZlc9HAh5JXylA+Zu7ssknBQDqbZHLA606ROmcRqYbnBvoPuUfl1G4KW5cRGdeZIZodUYrJepBbAC/epV9SP3gf5WFxKmPsF2X57o08V4gLIwMPzZbf9mzYYvynLslLV9A++VaxQOA3ESoLXRO3RPgws7rmwlXcDN4GwLtNmHwCG6b1Gw==",id);
                    var KzZXmrKZdKAIRN_query;
                    KzZXmrKZdKAIRN_query=qCompressed(1.0,"&30e$eJx9kltvozAQhf+M+7rCkEvzyMUQ2gSyNkqXvCAnuImhYDDOhf76NUHbVVUpj9ac+c545jw5U/D7zGS/npE9yJnkF5b7UlSusZ5hwzYIBaxWXPVJ3zCHAvT1IBPgxF5KFuBd6xMhPjrb1G1TAk2Q845We348U8VF7VFFbbg2f1buIGiBGIdBGNmrzEMbFHkocgewkPzIa6rBswGMTdfSrsgLkB72xDsl5DjKM3AxspMwjnRBNEze4WHumCDMbUgg/DUDftTK7hJsg7WxK/deZl25ZHGjfdphA3dQDsgrStxlhqIkTFLCQFcydTiN3w5zcgCuGz23fsDyqvXHqfACU7zHB8zwO4YGhlDLrtuWXJLCr6WxeCCzJjA8XtOi6VefD2R5WTTGtnZE198eyNibUZywzRBT6SPTHa166rA/e3+pJdYocdm4qQXwz8eOwuViVvL5y8s8s0SDbkqecw3RgSBvaJNkw/HHlGBz8o+i4bzuFK0PLKKVPi2A38C3yq6dFLUOozKus6loNlQpJmsNngA33qQ/Zvksd5NjGROvKMtXd2hxdNYYHVqmYI1wgL7cGeDdkF6HHkpH5H3ynzQHvtdEuCygIS6J8FA275oPruLmziGbVZj8BVK9/R0=",id);
                    annotation { "Feature Name" : "Extrude 12" }
                    extrude(context, id + "FAGoyYN1f6BkQS8_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([BknuTcNTcZTENY_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(35 * millimeter), 'expression' : "35 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([KzZXmrKZdKAIRN_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FAGoyYN1f6BkQS8_7(id));
        features.F6muD1e3ihqFVvJ_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var pWlicAAIkShGTJ_query;
                    pWlicAAIkShGTJ_query=qCompressed(1.0,"&2ab$eJx1Ul2PojAU/TPd1w2ogDxCKciMgtsSd/WFFNpgQSmWqsP8+gFNZjfZ+NLk9p6Pe0/uD98Cv65cDRubFIBxJW6chUqeobGxsDG+NjFngImengtRXakWsg2opp65mf3fyYaOE3MOUhxHceKt8wBtURKgBO6JC6QSlWjpqffsSZ5QwFst9DCxfArQd0EWAAURGic6il5L9fxcAoiRl8VpMjZkx9XDMmb+DMTMM4lp/rRBmFxUf4t20cY4NEWQz+9C8bQb3S/Tmg8hBsg7yuAqR0kWZ3vCQd9wXR6fA8SMlADCZHkJI87Ol/ARhYVt7OAldnGBS8wwH0H33YXcsjpsleG+BM0XZlzd93U3rD9fglhTd8au9WU/fLwE8d9GfcQeR1zvX9sd6HmgPv9ThCtsQWeMMvQgmnDEAaInmiodYheWz8RcEF6rnpor126E8/bm5HPZoQ+trozjcsrc2+YPBQub/Gn3D/ezOSyqJiVB3TTvMLdk50t54rQduQsA0+3+mzfGLPrptHxaNr5kQ/ZXyQFh0CW4qU1D3jIZoNzpu5PQaTfqWIBs13H2BRcT3JE=",id);
                    var XzxDaPlowjhBAH_query;
                    XzxDaPlowjhBAH_query=qCompressed(1.0,"&30e$eJx9kltvozAQhf+M+7rCkEvzyMUQ2gSyNkqXvCAnuImhYDDOhf76NUHbVVUpj9ac+c545jw5U/D7zGS/npE9yJnkF5b7UlSusZ5hwzYIBaxWXPVJ3zCHAvT1IBPgxF5KFuBd6xMhPjrb1G1TAk2Q845We348U8VF7VFFbbg2f1buIGiBGIdBGNmrzEMbFHkocgewkPzIa6rBswGMTdfSrsgLkB72xDsl5DjKM3AxspMwjnRBNEze4WHumCDMbUgg/DUDftTK7hJsg7WxK/deZl25ZHGjfdphA3dQDsgrStxlhqIkTFLCQFcydTiN3w5zcgCuGz23fsDyqvXHqfACU7zHB8zwO4YGhlDLrtuWXJLCr6WxeCCzJjA8XtOi6VefD2R5WTTGtnZE198eyNibUZywzRBT6SPTHa166rA/e3+pJdYocdm4qQXwz8eOwuViVvL5y8s8s0SDbkqecw3RgSBvaJNkw/HHlGBz8o+i4bzuFK0PLKKVPi2A38C3yq6dFLUOozKus6loNlQpJmsNngA33qQ/Zvksd5NjGROvKMtXd2hxdNYYHVqmYI1wgL7cGeDdkF6HHkpH5H3ynzQHvtdEuCygIS6J8FA275oPruLmziGbVZj8BVK9/R0=",id);
                    annotation { "Feature Name" : "Extrude 13" }
                    extrude(context, id + "F6muD1e3ihqFVvJ_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([pWlicAAIkShGTJ_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(35 * millimeter), 'expression' : "35 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : false, "extrudeDirection" : qUnion([]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([XzxDaPlowjhBAH_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F6muD1e3ihqFVvJ_7(id));
        features.FFfnqHgV6L3xTP9_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var UGdRXcIJmShHUD_query;
                    UGdRXcIJmShHUD_query=qCompressed(1.0,"&402$eJx9kl9zojAUxb9M9nWHAIo+8idYWgX3hrVrX5goUSMVMESr/fQN2LrdcdaZvGRyz++ee25+eD3068DledKjC5RzKY48D2W1c23fmPTBcA3KEC+VUOf0XHOPIXK9UBuFrk/oEK20Iq2q18Y1taxHsYly0bDdQqwPTImqDJhiLp6Yty8dCFsogWgUxe44C8iUxAGJ/bkGV1KsRck0GLdgMH1LdyXBiGi7G9GoSl6sDJAPxE2jJNYPVc1lB49yz0RR7mKK8c8+CuO9bI6j2WhivBSLILPehORJrfvs2ww6UI7oE0n9h4zEaZTOKUdNwdVycxk7yukSWTaO1m/zbX0ev4MJFjBYwNLnlzZDFB7WDcMPw34hnMdHJ7OqmpyUPOQcVjpN+kymadYmd4kYMPuiaLgoG8XKJY/ZTueC8D/g084tvTnZe5zJpMx6VT1lSnFZarCN/GQ6v/HyXrzY6yKhwbYonvxW4ulFcdZKemhCYHS10bmwLyuEXrsu6IMDg6/sYXihg54DsBZg7Zc/G9sNuJxwNf8bBuBBWzP8RJuL6xPWZ9kWdJDVZ7lp6Ztpd32MTvS9f/9Of9+PB/twxPPdPrxT9jbb02O6DUtpDAFbdyrzYlsbs9KrmvMJTOdOpfXCdmfm8T+L8OG6QQeJhiomVfiZQvs13Wm372/5dAPj1beBDbCW/03pRnj77xwUBnUMxRYb1TGtApI5Tf0qVFJrD9hBdDqO0oz+htZJFsUpAUr89AOBB0GT",id);
                    var pkAxoQVMUeyNAp_query;
                    pkAxoQVMUeyNAp_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromC0M6R0C0M6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$eW0jhRAeEetYR5R6R7R8S7$isStartFR9CcA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRcS8$CAP_EDGER5R6R7R8Sc$instanceNameS1$1R9CcA1S11.9$FxmAnBYEqBearOn_5opPatternRcS4$COPYR5R6R7R8R9CcA1S11.9$FzkZ4gkOSDjkkKC_5opBooleanRcR1d",id);
                    var JVpxHboYEqjEDX_query;
                    JVpxHboYEqjEDX_query=qCompressed(1.0,"&30e$eJx9kltvozAQhf+M+7rCkEvzyMUQ2gSyNkqXvCAnuImhYDDOhf76NUHbVVUpj9ac+c545jw5U/D7zGS/npE9yJnkF5b7UlSusZ5hwzYIBaxWXPVJ3zCHAvT1IBPgxF5KFuBd6xMhPjrb1G1TAk2Q845We348U8VF7VFFbbg2f1buIGiBGIdBGNmrzEMbFHkocgewkPzIa6rBswGMTdfSrsgLkB72xDsl5DjKM3AxspMwjnRBNEze4WHumCDMbUgg/DUDftTK7hJsg7WxK/deZl25ZHGjfdphA3dQDsgrStxlhqIkTFLCQFcydTiN3w5zcgCuGz23fsDyqvXHqfACU7zHB8zwO4YGhlDLrtuWXJLCr6WxeCCzJjA8XtOi6VefD2R5WTTGtnZE198eyNibUZywzRBT6SPTHa166rA/e3+pJdYocdm4qQXwz8eOwuViVvL5y8s8s0SDbkqecw3RgSBvaJNkw/HHlGBz8o+i4bzuFK0PLKKVPi2A38C3yq6dFLUOozKus6loNlQpJmsNngA33qQ/Zvksd5NjGROvKMtXd2hxdNYYHVqmYI1wgL7cGeDdkF6HHkpH5H3ynzQHvtdEuCygIS6J8FA275oPruLmziGbVZj8BVK9/R0=",id);
                    annotation { "Feature Name" : "Extrude 14" }
                    extrude(context, id + "FFfnqHgV6L3xTP9_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.REMOVE, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([UGdRXcIJmShHUD_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : true, "extrudeDirection" : qUnion([pkAxoQVMUeyNAp_query]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([JVpxHboYEqjEDX_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FFfnqHgV6L3xTP9_7(id));
        features.F1m0R0kcZ23Omig_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var qFwCdwWquIuWSg_query;
                    qFwCdwWquIuWSg_query=qCompressed(1.0,"&402$eJx9kl9zojAUxb9M9nWHAIo+8idYWgX3hrVrX5goUSMVMESr/fQN2LrdcdaZvGRyz++ee25+eD3068DledKjC5RzKY48D2W1c23fmPTBcA3KEC+VUOf0XHOPIXK9UBuFrk/oEK20Iq2q18Y1taxHsYly0bDdQqwPTImqDJhiLp6Yty8dCFsogWgUxe44C8iUxAGJ/bkGV1KsRck0GLdgMH1LdyXBiGi7G9GoSl6sDJAPxE2jJNYPVc1lB49yz0RR7mKK8c8+CuO9bI6j2WhivBSLILPehORJrfvs2ww6UI7oE0n9h4zEaZTOKUdNwdVycxk7yukSWTaO1m/zbX0ev4MJFjBYwNLnlzZDFB7WDcMPw34hnMdHJ7OqmpyUPOQcVjpN+kymadYmd4kYMPuiaLgoG8XKJY/ZTueC8D/g084tvTnZe5zJpMx6VT1lSnFZarCN/GQ6v/HyXrzY6yKhwbYonvxW4ulFcdZKemhCYHS10bmwLyuEXrsu6IMDg6/sYXihg54DsBZg7Zc/G9sNuJxwNf8bBuBBWzP8RJuL6xPWZ9kWdJDVZ7lp6Ztpd32MTvS9f/9Of9+PB/twxPPdPrxT9jbb02O6DUtpDAFbdyrzYlsbs9KrmvMJTOdOpfXCdmfm8T+L8OG6QQeJhiomVfiZQvs13Wm372/5dAPj1beBDbCW/03pRnj77xwUBnUMxRYb1TGtApI5Tf0qVFJrD9hBdDqO0oz+htZJFsUpAUr89AOBB0GT",id);
                    var YEGHDaZeNLgkFv_query;
                    YEGHDaZeNLgkFv_query=qCompressed(1.0,"&2bc$eJyFkVuPmzAQhf+M+5go5po8cjEsSYGsjVKRF2SCk7iUm4E02V9fB7SV2qjq08gan2/OnPli6+B9ZOIR6iQHBRP8xgpPNJWlOKtQx6upGrKuCAWsHvjwSB4tsylAvx9EA57lILIBZ6lMmuZHP8sJVEDBe1rl/DLSgTe1SwdqwVB57UwgqIIYB34QWV8zF+1R5KLISSW4EfzCayrBcPKlOKqcilwfSdtX3g+NmK2sgYORlQRxJBtNy8QEDwpbAUFhQQLh0gBe1In+5h/8cHUsczdTf3LB4lbO6Z5ZTKACkB1KnLcMRUmQpISBvmTD6TqvHRTkBA7R+l5HXX/cIYgVrGKKc3xy2DxmA7zx0lP4tjFKbm63ZqY2LboPYiwYPss0yTe0T7JncnPEGNJPioTzuh9ofWIRrWQuAP4BvldWbaeosxkVcZ3pTbunw8BELcEacOJ9+uLlozxqlzIm7vey3DlPiS0PxehTooMQYR9NyeoYGq/LLKApb+w3jzSCZ8Mu38k6M/EZw81ffxeKtjSXCwWC/BOPFe1/ZKMaXchUfu28w237L/Jaco2JPUF/AaWq3D4=",id);
                    var gxsVmBAAtObYgq_query;
                    gxsVmBAAtObYgq_query=qCompressed(1.0,"%B5$QueryM5Sb$derivedFromC0M6S12$disambiguationDataA1M2S12$disambiguationTypeS13$ORIGINAL_DEPENDENCYS9$originalsA1C0M5Sa$entityTypeBa$EntityTypeS4$EDGESb$historyTypeS8$CREATIONSb$operationIdB2$IdA1S11.6$FNqrsvGVGM0ZkbD_3wireOpS9$queryTypeSd$SKETCH_ENTITYSe$sketchEntityIdSc$eW0jhRAeEetYR5R6R7R8S7$isStartFR9CcA1S11.9$Fugsa1H96ki7JJ7_3opExtrudeRcS8$CAP_EDGER5R6R7R8R9CcA1S11.9$FzkZ4gkOSDjkkKC_5opBooleanRcS4$COPY",id);
                    var IhUahDfqSdEDch_query;
                    IhUahDfqSdEDch_query=qCompressed(1.0,"&32e$eJx9kl2PojAUhv9M93I3FPwYL/koyKjgtsQZvCFVOloQiqU64q/fItlNNibeNGn6vs95z+n54YzB7wuT3WpMdiBnkl9Z7ktRucZqjA19TrBhG4QCViuuuqRrmEMB+nchI+DEXkpm4Eu7EiFOrW32ZgJNkPOWVjt+uFDFRe1RRW24Mp9fHiBogRiHQRjZy8xDaxR5KHJ7sJD8wGuqwZNHKtO1dFXkBUhHPvJWCTlEeQMuRnYSxpF+EA2TD3iYOyYIcxsSCH9NgB+dZXsNNsHK2JY7L7O+uWRxo+uc+zk8QDkgC5S48wxFSZikhIG2ZGp/HNoOc7IHrhu9nf2A5dXZH1LhGaZ4h/eY4S8MDQyhln1vzuSaFH4tjdkLmTWC4eE7LZpueX8hy8uiMTa1I9ru9kLGPoziiG2GmEpfFd3SqqMO+9z5cy2xBonLhknNgH85tBTOZ5OST9/fp5klGnRT8pJriF4I8oHWSdZ//rAl2Bz9pWg4r1tF6z2LaKW/FsD/wLfKrp0UnR1GZVxnY9GsqVJM1ho8Am68Tp+y3Mvt6FDGxCvKcuH2FkfvGqO9ZQxWCAfouYcp8L0mwmUBDXFNhIeyaducuIqbh4usl2Hy7PppUuB/nhY8CO/CtBPuaJ+em2X+AcdQBPw=",id);
                    annotation { "Feature Name" : "Extrude 15" }
                    extrude(context, id + "F1m0R0kcZ23Omig_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([qFwCdwWquIuWSg_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.UP_TO_SURFACE, "oppositeDirection" : false, "depth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "endBoundEntityFace" : qUnion([YEGHDaZeNLgkFv_query]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : true, "extrudeDirection" : qUnion([gxsVmBAAtObYgq_query]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([IhUahDfqSdEDch_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.F1m0R0kcZ23Omig_7(id));
        features.Fts3uFUI22zxKQK_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var jObAaxEvcagjeA_query;
                    jObAaxEvcagjeA_query=qCompressed(1.0,"&469$eJyNk29zojAQxr9M7uXdEEDRl/wJlLaCt+Fs9Q0TJbWRCgjR1n76Bqi2N845N8ObZHefffa34YczQL/3vD5OBnSJMl6LA8/8utzapqtNhqDZGmWIF1LIY3KsuMMQOR+oiXzbJXSMnlRFUpYvja2rsgHFOspEw7ZLsd4zKcrCY5LZeKJfRjohbKAYwiCM7PvUI1MSeSRy50q4rMVaFEwJ41YYdNdQXYkXEGX3WTSyrHsrI+QCsZMwjlSgrHjdiYeZo6MwszHF+NcQ+dGubg7BLJhoi3zppcarqHlcqT67lkEnlCF6RxL3JiVREiZzylGTc7l67scOM7pC/EHbPIPNCZdz0MEABktYubxvM0b+ft0wfDMe5sK6vbVSo6zIm6z3GYcnRZM+kGmStuR6xIDZSUWJi6KRrFjxiG0VF4T/En7b2oUzJzuHszou0kFZTZmUvC6UsInceDq/8PKeL8x1HlNvk+d3blviqEVx1pYM0IRAQDqy2slM58XsFwmDdmkwBAtGpw3AuO8BahrAqgAr14aJw/XrfFMd79+/kAAetTnjT2l9eQ5h9a3ahE7k6TNdN9RJNy+ZWsj3qgjyDdbKQ1J6JLWa6kXIuOqmoNP7MDlPcZrlu/fhFe+uG412fsCz7c6/kvY629FDsvGLWhuDbl3JzPJNpc0Kp2yOb4CNa9gWbHtkDn9c+jfnN2Ah0VDJaul/Emwftz3tXsw3th0she7rxtDUjYEvQGhgav8k/x+Cl/v4qauf6fHlTgThe6nbiXDURpRRbPW7SOkfaO2mYZQQoMRNPgA+D16l",id);
                    var HIBsdjdBblyjgo_query;
                    HIBsdjdBblyjgo_query=qCompressed(1.0,"&361$eJxlUlt3ojAQ/jOzj3pIFKmPXKKlreBOqF37womQtZEKFKKt++s3YGu325fkJDPfZS4/PBt+HmRzWth8A7ls1FHms6bau9S3FjZa5pycT04o5KoV+43aHoRWVRkILVyyoN8jyamWnIwgxnAeRu5dGrAliwIW+Ws+hapRW1WK59YlnQgXIEut9KlDeQLY5cHHwII5M86eVKur5vx5BT4yNwnjyASqWja9ZJh7FMLcJZyQ4QRm0UvTHuer+cJ6LDZBOnpVjYxro/7SldsT5cBvWeJfpyxKwmTNJbSF1NnT2UCY8wzkg7V7Qlcyqddo4wQdvOIOqJZr0egZTv3srDiF2WHbCnI9nRTKublx0lFVszfdHHKJWefZXaZdMReWDFTZalFmMhJ70y0gX9je9m7prdmLJ0UTl6ld1UuhtWxKwzYGP15e/HyB/Skex9si5sGuKG79DuZV1bMUBoYk72dKXLqgSHGE4/cpX4hwY9JylMZcXuxqa1V6VXt6Q2IZhHUe1+f9uRuGkyA1RL7DJ7BimLBfPSMZmx4hmRjTom/Be8xG6pwTTFR0KVlv8DMwRWr9//VRpwOzoI6w2BGrOiZVwFKnrZ+VjmujQxzgy7swSfk9zlyfpWGUMOTMT5Dy35DgPftnHb83cUDM9pC9hVaRPdJRvFfb1On98we2TL4M8R01oGLoDAfUgs1Hs7kNC4Zz9hc9xQr4",id);
                    var vzaIFxuYSkZmyr_query;
                    vzaIFxuYSkZmyr_query=qCompressed(1.0,"&340$eJx9kluvojAUhf9M53EmFLwcHykU5KjgtMRz8IVU6dGCUG5e8NdPkcyZTEx8adJ0rW+vvbt/oDH4feZ1t5rQHUh4LS48cWqZW9pqTDR1TohmapQBXrSi7cKu5IgB/H2hI4ACO6Iz8KVcoZSnxtR7M4U6SETD8p04nFkrZGGzlplwpT+/PEDQAAHxXM83l7GN19i3sW/1YFmLgyiYAk8eqXTLUFWx7WIV+SiaVtZDlDdgEWyGXuCrB1ny+gH3EqQDLzEhhfDXBDh+VTcXd+OutG22s2PjKmoelKpO1c/hAUoAXeDQmsfYD70wohw0GW/3x6FtL6F7YFn+W+W4PMkrZ0hFZoSRHdkTTr4I1AiESnbdVPQSpk5Ra7MXMmMEvcM1SstueX8hS7K01DYFkk13eyHjH1p6JCbHvI1eFd2yvGOIf+6cuZIYg8Tiw6RmwDkfGgbns0kmpu/v09iQJb619TlRELUQ9AOvw7j//GFLiD76S1FwUTQtK/bcZ7n6WgD/A99ys0ARrhBndVDEY1muWdvyulDgEbCCdfSU5Z5tR4csoHaaZQurtyC1a5z1ljFYYeLi5x6mwLFLn2Qp1OQllDaOp015Em1QPlx0vfTC78wciKbffMT2GZJJF/7j/NQZcD5PC+F6d6mboUCKpCZp6H8AkjkLnA==",id);
                    annotation { "Feature Name" : "Extrude 16" }
                    extrude(context, id + "Fts3uFUI22zxKQK_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.REMOVE, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([jObAaxEvcagjeA_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.BLIND, "oppositeDirection" : false, "depth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "endBoundEntityFace" : qUnion([]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : true, "extrudeDirection" : qUnion([HIBsdjdBblyjgo_query]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([vzaIFxuYSkZmyr_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.Fts3uFUI22zxKQK_7(id));
        features.FkZ46qgJns3IOIb_7 = function(id)
            {
                annotation { 'unused' : true }
                var features = features;
                if (true)
                {
                    {
                    }
                    var ZQRzLaaQMuzytf_query;
                    ZQRzLaaQMuzytf_query=qCompressed(1.0,"&469$eJyNk29zojAQxr9M7uXdEEDRl/wJlLaCt+Fs9Q0TJbWRCgjR1n76Bqi2N845N8ObZHefffa34YczQL/3vD5OBnSJMl6LA8/8utzapqtNhqDZGmWIF1LIY3KsuMMQOR+oiXzbJXSMnlRFUpYvja2rsgHFOspEw7ZLsd4zKcrCY5LZeKJfRjohbKAYwiCM7PvUI1MSeSRy50q4rMVaFEwJ41YYdNdQXYkXEGX3WTSyrHsrI+QCsZMwjlSgrHjdiYeZo6MwszHF+NcQ+dGubg7BLJhoi3zppcarqHlcqT67lkEnlCF6RxL3JiVREiZzylGTc7l67scOM7pC/EHbPIPNCZdz0MEABktYubxvM0b+ft0wfDMe5sK6vbVSo6zIm6z3GYcnRZM+kGmStuR6xIDZSUWJi6KRrFjxiG0VF4T/En7b2oUzJzuHszou0kFZTZmUvC6UsInceDq/8PKeL8x1HlNvk+d3blviqEVx1pYM0IRAQDqy2slM58XsFwmDdmkwBAtGpw3AuO8BahrAqgAr14aJw/XrfFMd79+/kAAetTnjT2l9eQ5h9a3ahE7k6TNdN9RJNy+ZWsj3qgjyDdbKQ1J6JLWa6kXIuOqmoNP7MDlPcZrlu/fhFe+uG412fsCz7c6/kvY629FDsvGLWhuDbl3JzPJNpc0Kp2yOb4CNa9gWbHtkDn9c+jfnN2Ah0VDJaul/Emwftz3tXsw3th0she7rxtDUjYEvQGhgav8k/x+Cl/v4qauf6fHlTgThe6nbiXDURpRRbPW7SOkfaO2mYZQQoMRNPgA+D16l",id);
                    var vTpJTnlibxJZNj_query;
                    vTpJTnlibxJZNj_query=qCompressed(1.0,"&2bc$eJyFkUtvozAUhf+MZ5kI80yWPAwhLZDaqCOyQSY4qUt5xECa9NePA+pIM9FoVlfW1fnuOcc/HAO8jEzcIoMUoGSCX1jpi7a2VVeJDKxM05RTIRSwZuDDLb11zKEA/X4QHfi2i8gaHKUybduPfpYTqIKS97Qu+GmkA28bjw7UhpH6uJlAUAMJDoMwtp9zD+1Q7KHYzSS4FfzEGyrBcPKlupq8irwASdtvvB9aMVtZARcjOw2TWC7ajokJHpaOCsLShgTCpQn8+Cz6S/AaRMq+Krxc++SCJZ28c753MYFKQJ5Q6m5yFKdhmhEG+ooNh7c5dliSA/h8PZNL+u43QlljFWuY4gIfXDafWQN/PPUUbtZmxa3t1sq1tkPXQYwlw0fZJvmJdml+b26uGEP6TZFw3vQDbQ4sprXsBcA/wNfabpwMnR1GRdLkRtvt6DAw0UiwDtxklz14+ar2+qlKiPdeVU/uXeLIj2L0LjFAhHCApmYNDM3HMAtoAb8e40ygl+3tWjebKLfwEcO/gy9UfWktFyoExTceq/r/yIlmZenRWH08E3Nv/ou8klxzYk/QX1nS3Jk=",id);
                    var LomYgGVKJvgrtF_query;
                    LomYgGVKJvgrtF_query=qCompressed(1.0,"&361$eJxlUlt3ojAQ/jOzj3pIFKmPXKKlreBOqF37womQtZEKFKKt++s3YGu325fkJDPfZS4/PBt+HmRzWth8A7ls1FHms6bau9S3FjZa5pycT04o5KoV+43aHoRWVRkILVyyoN8jyamWnIwgxnAeRu5dGrAliwIW+Ws+hapRW1WK59YlnQgXIEut9KlDeQLY5cHHwII5M86eVKur5vx5BT4yNwnjyASqWja9ZJh7FMLcJZyQ4QRm0UvTHuer+cJ6LDZBOnpVjYxro/7SldsT5cBvWeJfpyxKwmTNJbSF1NnT2UCY8wzkg7V7Qlcyqddo4wQdvOIOqJZr0egZTv3srDiF2WHbCnI9nRTKublx0lFVszfdHHKJWefZXaZdMReWDFTZalFmMhJ70y0gX9je9m7prdmLJ0UTl6ld1UuhtWxKwzYGP15e/HyB/Skex9si5sGuKG79DuZV1bMUBoYk72dKXLqgSHGE4/cpX4hwY9JylMZcXuxqa1V6VXt6Q2IZhHUe1+f9uRuGkyA1RL7DJ7BimLBfPSMZmx4hmRjTom/Be8xG6pwTTFR0KVlv8DMwRWr9//VRpwOzoI6w2BGrOiZVwFKnrZ+VjmujQxzgy7swSfk9zlyfpWGUMOTMT5Dy35DgPftnHb83cUDM9pC9hVaRPdJRvFfb1On98we2TL4M8R01oGLoDAfUgs1Hs7kNC4Zz9hc9xQr4",id);
                    var ZTYYtAtTpozRoT_query;
                    ZTYYtAtTpozRoT_query=qCompressed(1.0,"&32e$eJx9kl2PojAUhv9M93I3FPwYL/koyKjgtsQZvCFVOloQiqU64q/fItlNNibeNGn6vs95z+n54YzB7wuT3WpMdiBnkl9Z7ktRucZqjA19TrBhG4QCViuuuqRrmEMB+nchI+DEXkpm4Eu7EiFOrW32ZgJNkPOWVjt+uFDFRe1RRW24Mp9fHiBogRiHQRjZy8xDaxR5KHJ7sJD8wGuqwZNHKtO1dFXkBUhHPvJWCTlEeQMuRnYSxpF+EA2TD3iYOyYIcxsSCH9NgB+dZXsNNsHK2JY7L7O+uWRxo+uc+zk8QDkgC5S48wxFSZikhIG2ZGp/HNoOc7IHrhu9nf2A5dXZH1LhGaZ4h/eY4S8MDQyhln1vzuSaFH4tjdkLmTWC4eE7LZpueX8hy8uiMTa1I9ru9kLGPoziiG2GmEpfFd3SqqMO+9z5cy2xBonLhknNgH85tBTOZ5OST9/fp5klGnRT8pJriF4I8oHWSdZ//rAl2Bz9pWg4r1tF6z2LaKW/FsD/wLfKrp0UnR1GZVxnY9GsqVJM1ho8Am68Tp+y3Mvt6FDGxCvKcuH2FkfvGqO9ZQxWCAfouYcp8L0mwmUBDXFNhIeyaducuIqbh4usl2Hy7PppUuB/nhY8CO/CtBPuaJ+em2X+AcdQBPw=",id);
                    annotation { "Feature Name" : "Extrude 17" }
                    extrude(context, id + "FkZ46qgJns3IOIb_7", { "domain" : OperationDomain.MODEL, "bodyType" : ExtendedToolBodyType.SOLID, "operationType" : NewBodyOperationType.ADD, "surfaceOperationType" : NewSurfaceOperationType.NEW, "flatOperationType" : FlatOperationType.REMOVE, "entities" : qUnion([ZQRzLaaQMuzytf_query]), "surfaceEntities" : qUnion([]), "wallShape" : qUnion([]), "midplane" : false, "thickness1" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "flipWall" : false, "thickness2" : { 'value' : try(0 * millimeter), 'expression' : "0 mm" }.value, "thickness" : { 'value' : try(5 * millimeter), 'expression' : "5 mm" }.value, "endBound" : BoundingType.UP_TO_SURFACE, "oppositeDirection" : false, "depth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "endBoundEntityFace" : qUnion([vTpJTnlibxJZNj_query]), "endBoundEntityBody" : qUnion([]), "endBoundEntityVertex" : qUnion([]), "hasOffset" : false, "offsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "offsetOppositeDirection" : false, "hasExtrudeDirection" : true, "extrudeDirection" : qUnion([LomYgGVKJvgrtF_query]), "startOffset" : false, "startOffsetBound" : StartOffsetType.BLIND, "startOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "startOffsetOppositeDirection" : false, "startOffsetEntity" : qUnion([]), "symmetric" : false, "hasDraft" : false, "draftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "draftPullDirection" : false, "hasSecondDirection" : false, "secondDirectionBound" : BoundingType.BLIND, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionBoundEntityFace" : qUnion([]), "secondDirectionBoundEntityBody" : qUnion([]), "secondDirectionBoundEntityVertex" : qUnion([]), "hasSecondDirectionOffset" : false, "secondDirectionOffsetDistance" : { 'value' : try(25 * millimeter), 'expression' : "25 mm" }.value, "secondDirectionOffsetOppositeDirection" : false, "hasSecondDirectionDraft" : false, "secondDirectionDraftAngle" : { 'value' : try(3 * degree), 'expression' : "3 deg" }.value, "secondDirectionDraftPullDirection" : false, "defaultScope" : false, "booleanScope" : qUnion([ZTYYtAtTpozRoT_query]), "defaultSurfaceScope" : true, "booleanSurfaceScope" : qUnion([]), "asVersion" : FeatureScriptVersionNumber.V2960_DELETE_FAILED_FLAT_BY_PART });
                }
            };
        try(features.FkZ46qgJns3IOIb_7(id));
    }, millimeter, { "HP_Count0" : 26.0 * unitless, "Front_Height" : 30.0 * millimeter, "RearHeight" : 30.0 * millimeter, "List_sltuiwY7bs5tJx" : List_sltuiwY7bs5tJx_conf.Default, "Upper_Round" : 1.0 * millimeter, "Upper_Chamfer" : 1.0 * millimeter, "List_5KGcbwyvF0AOZo" : List_5KGcbwyvF0AOZo_conf.Default, "Lower_Round" : 1.0 * millimeter, "Lower_Lip_Bevel" : 1.0 * millimeter });
