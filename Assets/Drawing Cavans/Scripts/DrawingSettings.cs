using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace FreeDraw
{
    
    public class DrawingSettings : MonoBehaviour
    {
        public static bool isCursorOverUI = false;
        public float Transparency = 1f;

        
        public void SetMarkerColour(Color new_color)
        {
            Drawable.Pen_Colour = new_color;
        }
        
        public void SetMarkerWidth(int new_width)
        {
            Drawable.Pen_Width = new_width;
        }
        public void SetMarkerWidth(float new_width)
        {
            SetMarkerWidth((int)new_width);
        }

        public void SetTransparency(float amount)
        {
            Transparency = amount;
            Color c = Drawable.Pen_Colour;
            c.a = amount;
            Drawable.Pen_Colour = c;
        }


        // BEBSI
        public void SetMarkerRed()
        {
            Color c = Color.red;
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }
        public void SetMarkerGreen()
        {
            Color c = Color.green;
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }
        public void Eerase()
        {
            Color c = Color.white;
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }
        public void SetMarkerBlue()
        {
            Color c = Color.blue;
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetMarkerYellow()
        {
            Color c = Color.yellow;
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetMarkeroPurple()
        {
            Color c = Color.magenta;
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetMarkerBlack()
        {
            Color c = Color.black;
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        //New Colors

        public void SetMarkerCyan()
        {
            Color c = Color.cyan;
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetMarkerOrange()
        {
            Color c = new Color(1.0f, 0.5f, 0.0f); // Orange color
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetMarkerPink()
        {
            Color c = new Color(1.0f, 0.41f, 0.71f); // Pink color
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetMarkerBrown()
        {
            Color c = new Color(0.6f, 0.4f, 0.2f); // Brown color
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetMarkerGray()
        {
            Color c = Color.gray;
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetMarkerLime()
        {
            Color c = Color.Lerp(Color.green, Color.white, 0.5f); // Lime color
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetMarkerTurquoise()
        {
            Color c = new Color(0.25f, 0.88f, 0.82f); // Turquoise color
            c.a = Transparency;
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        //Emo Colors

        public void SetDarkerRed()
        {
            Color c = Color.red;
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerGreen()
        {
            Color c = Color.green;
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        
        public void SetDarkerBlue()
        {
            Color c = Color.blue;
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerYellow()
        {
            Color c = Color.yellow;
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerPurple()
        {
            Color c = Color.magenta;
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerBlack()
        {
            Color c = Color.black;
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        // Darker versions for new colors

        public void SetDarkerCyan()
        {
            Color c = Color.cyan;
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerOrange()
        {
            Color c = new Color(1.0f, 0.5f, 0.0f); // Orange color
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerPink()
        {
            Color c = new Color(1.0f, 0.41f, 0.71f); // Pink color
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerBrown()
        {
            Color c = new Color(0.6f, 0.4f, 0.2f); // Brown color
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerGray()
        {
            Color c = Color.gray;
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerLime()
        {
            Color c = Color.Lerp(Color.green, Color.white, 0.5f); // Lime color
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }

        public void SetDarkerTurquoise()
        {
            Color c = new Color(0.25f, 0.88f, 0.82f); // Turquoise color
            c.a = Transparency;
            c *= 0.7f; // Darker version by reducing RGB values
            SetMarkerColour(c);
            Drawable.drawable.SetPenBrush();
        }



    }
}