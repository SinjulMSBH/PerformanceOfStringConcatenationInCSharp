## SinjulMSBH \\ Performance Of String Concatenation In C# And .NET Core

### SingleLineJoin
| Method | Mean |
|---|---|
| Interpolation | 250.9 ns | 
| PlusOperator | 246.9 ns |
| StringConcatenate | 246.9 ns |
| StringJoin | 229.6 ns |
| StringFormat | 590.7 ns | 
| StringBuilderAppend | 184.5 ns |

### StringJoinComparison
| Method | Mean |
|---|---|
| StringJoin | 135.7 ns | 
| StringJoinList | 221.4 ns |
  
### OperatorTest  
| Method | Mean |
|---|---|
| PlusOperatorWithResult | 344.6 ns | 
| PlusOperator | 304.9 ns |
