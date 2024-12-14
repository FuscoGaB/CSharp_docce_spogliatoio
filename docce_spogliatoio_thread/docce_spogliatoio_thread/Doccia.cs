using System;
using System.Windows.Forms;
using System.Timers;

public class Doccia
{
    private string id;
    public string Id
    {
        get { return id; }
    }

    private bool occupata;
    public bool Occupata
    {
        get { return occupata; }
        set { occupata = value; }
    }

    private int tempoRimanente;
    public int TempoRimanente
    {
        get { return tempoRimanente; }
        set { tempoRimanente = value; }
    }

    private System.Timers.Timer timer;

    public Doccia(string id)
    {
        this.id = id;
        this.occupata = false;
        this.tempoRimanente = 0;
        this.timer = new System.Timers.Timer();
        this.timer.Interval = 1000;
        this.timer.Elapsed += TimerElapsed;
    }

    public void UsaDoccia(int durataInSecondi)
    {
        if (!occupata)
        {
            occupata = true;
            tempoRimanente = durataInSecondi;
            timer.Start();
            //doccia1.Text = $"La doccia {id} è stata occupata per {durataInSecondi} secondi.";
        }
        else
        {
            //doccia1.Text = $"La doccia {id} è già occupata.";
        }
    }

    public void LiberaDoccia()
    {
        if (occupata)
        {
            timer.Stop();
            occupata = false;
            tempoRimanente = 0;
            //doccia1.Text = $"La doccia {id} è stata liberata.";
        }
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        if (tempoRimanente > 0)
        {
            tempoRimanente--;
            //label1.Text = $"Doccia {id}: {tempoRimanente} secondi rimasti.";

            if (tempoRimanente == 0)
            {
                LiberaDoccia();
            }
        }
    }
    

}
