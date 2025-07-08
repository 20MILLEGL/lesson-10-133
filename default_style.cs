using System;
using System.ComponentModel;
using DocumentFormat.OpenXml.Wordprocessing;

// Add your C# classes, methods, or logic here.  
public class DefaultStyle
{
    // Example property  
    [Description("Placeholder for default style logic.")]
    public string ExampleProperty { get; set; } = "Replace with actual implementation.";

    // Example method to create a default Body element  
    public Body CreateDefaultBody()
    {
        return new Body();
    }
}

// Fixing syntax errors and invalid context issues  
// Removed invalid CSS-like syntax and replaced it with valid C# code  
public class FontStyle
{
    public string FontFamily { get; set; } = "Arial, sans-serif";
    public string BackgroundColor { get; set; } = "#f4f4f4";
    public string Margin { get; set; } = "0";
    public string Padding { get; set; } = "0";
}

public class ContainerStyle
{
    public string Display { get; set; } = "flex";
    public string FlexWrap { get; set; } = "wrap";
    public string JustifyContent { get; set; } = "center";
    public string Padding { get; set; } = "20px";
    public string Gap { get; set; } = "20px";
}

public class CardStyle
{
    public string Background { get; set; } = "white";
    public string Border { get; set; } = "1px solid #ccc";
    public string BorderRadius { get; set; } = "12px";
    public string BoxShadow { get; set; } = "0 4px 8px rgba(0,0,0,0.1)";
    public string Width { get; set; } = "28%";
    public string Padding { get; set; } = "20px";
    public string BoxSizing { get; set; } = "border-box";
    public string Transition { get; set; } = "transform 0.3s";
}

public class CardHoverStyle
{
    public string Transform { get; set; } = "scale(1.02)";
}

public class CardTextStyle
{
    public string FontSize { get; set; } = "1.5em";
    public string MarginBottom { get; set; } = "10px";
    public string Color { get; set; } = "#333";
}
