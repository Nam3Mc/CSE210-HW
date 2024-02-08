using System ;
using System.Diagnostics;
using System.Drawing;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public abstract class Shape
{
    private string _color ;

    public Shape ( string color )
    {
        _color = color ;
    }

    public string GetColor ( ) 
    {
        return _color ;
    }

    public void SetColor ( string color ) 
    {
        _color = color ;
    }

    public virtual double GetArea () 
    {
        return 0 ;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}