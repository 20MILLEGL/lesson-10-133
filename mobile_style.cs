// This file previously contained CSS, which is not valid C# code and caused compilation errors.
// If you want to use these styles in a C# project, consider embedding them as a string or moving them to a .css file.

// Example: Embedding CSS as a string for use in a web project
public static class MobileStyles
{
    public const string Css = @"
body {
    font-family: Arial, sans-serif;
    background: #ffffff;
}

.container {
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 10px;
    gap: 10px;
}

.card {
    width: 90%;
    background: #fefefe;
    border: 1px solid #ddd;
    border-radius: 8px;
    padding: 15px;
    box-shadow: 0 1px 4px rgba(0,0,0,0.05);
}

.card h2 {
    font-size: 1.1em;
}

.card p {
    font-size: 0.9em;
}
";
}
