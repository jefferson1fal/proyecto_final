using MauiApp1.Clases; // Importa el espacio de nombres MauiApp1.Clases

namespace MauiApp1
{
    public partial class MainPage : ContentPage // Clase parcial MainPage que hereda de ContentPage
    {
        private bool Informacion_Sedan = false; // Variable booleana que indica si se ha proporcionado información para Sedan
        private bool Informacion_Pickup = false; 
        private bool Informacion_Camioneta = false; 
        private bool Informacion_Jeep = false; 
        private string pickupMethod; // Variable de cadena que almacena métodos del Pickup
        private string Jeep_Informacion; 
        private string JeepMethod; 

        public string CamionetaMethod { get; private set; } // Propiedad de solo lectura 
        public MainPage()
        {
            InitializeComponent(); // Inicializa los componentes de la interfaz de usuario asociados con esta página
        }
        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (Informacion_Sedan)
            {
                // Si ya se mostró la información del sedán, restablece el estado y oculta la etiqueta sedanLabel
                Informacion_Sedan = false;
                sedanLabel.Text = string.Empty; // Oculta la información de la etiqueta sedanLabel
            }
            else
            {
                // Si la información del sedán no se ha mostrado, crea una nueva instancia del objeto Auto_Sedan
                Auto_Sedan sedan = new Auto_Sedan();

                // Configura los atributos del objeto sedan
                sedan.Tipo_Auto = "Toyota";
                sedan.Modelo_Auto = "Corolla";
                sedan.Color_Auto = "Gris";
                sedan.Año_Auto = 2021;
                sedan.Identificacion_Auto = "DEF456";
                sedan.Marca_Auto = "Sedán";

                // Realiza varias acciones en el objeto sedan, como encenderlo, acelerar, tocar la bocina, frenar y apagarlo
                sedan.Start();
                sedan.Pedal_Acelerar(40);
                sedan.Pito();
                sedan.Pedal_Freno();
                sedan.Apagar_Vehiculo();

                // Construye una cadena de texto que contiene la información del sedán y la asigna a la propiedad Text de la etiqueta sedanLabel
                string sedanInfo = $"Marca: {sedan.Tipo_Auto}" +
                    $"\nModelo: {sedan.Modelo_Auto}" +
                    $"\nColor: {sedan.Color_Auto}" +
                    $"\nAño: {sedan.Año_Auto}" +
                    $"\nPlaca: {sedan.Identificacion_Auto}" +
                    $"\nTipo: {sedan.Marca_Auto}";
                sedanLabel.Text = sedanInfo; // Muestra la información en la etiqueta sedanLabel

                Informacion_Sedan = true; // Establece el estado de Informacion_Sedan a verdadero, indicando que se ha mostrado la información
            }
        }
        private void OnCounterClickeda(object sender, EventArgs e)        //boton pitar 
        {
            if (Informacion_Sedan)
            {
                // Si ya se mostró la información del sedán, restablece el estado y oculta la etiqueta sedanLabel
                Informacion_Sedan = false;
                sedanLabel.Text = string.Empty; // Oculta la información de la etiqueta sedanLabel
            }
            else
            {
                // Si la información del sedán no se ha mostrado, crea una nueva instancia del objeto Auto_Sedan
                Auto_Sedan sedan = new Auto_Sedan();

                // Llama al método Pito() en el objeto sedan, que probablemente activa la bocina del sedán
                sedan.Pito();

                // Construye una cadena de texto que contiene la acción de pitar y la agrega al contenido actual de la etiqueta sedanLabel
                string sedanMethod = $"\nBocina: {sedan.Pito()}";
                sedanLabel.Text += sedanMethod;

                Informacion_Sedan = true; // Establece el estado de Informacion_Sedan a verdadero, indicando que se ha mostrado la información
            }
        }


        private void OnCounterClickeda1(object sender, EventArgs e)  //boton encender 
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Start();
           string  sedanMethod = $"\nEncendido: {sedan.Start()}";
            sedanLabel.Text += sedanMethod;
            Informacion_Sedan = true;
        }


    }
        
    private void OnCounterClickeda2(object sender, EventArgs e)   // boton apagar sedan 
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Apagar_Vehiculo();
            string sedanMethod = $"\nApagado: {sedan.Apagar_Vehiculo()}";
            sedanLabel.Text += sedanMethod;
            Informacion_Sedan = true;
        }

    }

    private void OnCounterClickeda3(object sender, EventArgs e)   // boton de aceletar 
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Pedal_Acelerar(40);
            string sedanMethod =  $"\nAcelerando en: {sedan.Pedal_Acelerar(5)} km/h";
            sedanLabel.Text += sedanMethod;
            Informacion_Sedan = true;
        }

    }

    private void OnCounterClickeda4(object sender, EventArgs e)   // boton de frenar
    {
        if (Informacion_Sedan)
        {
            Informacion_Sedan = false;
            sedanLabel.Text = string.Empty; // Oculta la información de la label sedan
        }
        else
        {
            Auto_Sedan sedan = new Auto_Sedan();
            sedan.Pedal_Freno();
            string sedanMethod = $"\nFrenando: de a - {sedan.Pedal_Freno(10)}";
            sedanLabel.Text += sedanMethod;
            Informacion_Sedan = true;
        }

    }

    private void OnCounterClicked1(object sender, EventArgs e)
    {
        if (Informacion_Pickup)
        {
            Informacion_Pickup = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            PickUp pickUp = new PickUp();
            pickUp.Tipo_Auto = "Ford";
            pickUp.Modelo_Auto = "Ranger";
            pickUp.Color_Auto = "blanco";
            pickUp.Año_Auto = 2022;
            pickUp.Identificacion_Auto = "ABC123";
            pickUp.Marca_Auto = "PickUp";
            //atributos del pickup
            pickUp.Start();
            pickUp.Pedal_Acelerar();
            pickUp.Pito();
            pickUp.Cargar();
            pickUp.Apagar_Vehiculo();
            pickUp.Pedal_Freno();

            string pickUpInfo = $"Marca: {pickUp.Tipo_Auto}" +
                $"\nModelo: {pickUp.Modelo_Auto}" +
                $"\nColor: {pickUp.Color_Auto}" +
                $"\nAño: {pickUp.Año_Auto}" +
                $"\nPlaca: {pickUp.Identificacion_Auto}" +
                $"\nTipo: {pickUp.Marca_Auto}";
            pickUpLabel.Text = pickUpInfo; // Muestra la información
            //string pickupMethod = $"\nBocina: {pickUp.Pito()}";
            //pickupMethod += $"\nApagado: {pickUp.Apagar_Vehiculo()}";
            //pickupMethod += $"\nEncendido: {pickUp.Start()}";
            //pickupMethod += $"\nAcelerando en: {pickUp.Pedal_Acelerar(5)} unidades";
            //pickupMethod += $"\nFrenando: de a {pickUp.Pedal_Freno(10)}";
            // pickupMethod += $"\ncargando la: {pickUp.Cargar(500w)}";
            //pickUpLabel.Text += pickupMethod;
            Informacion_Pickup = true;
        }

    }

    private void OnCounterClickedp(object sender, EventArgs e)        //boton pitar pickup 
    {
        if (Informacion_Pickup)
        {
            Informacion_Pickup = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {

            PickUp pickUp = new PickUp();
            pickUp.Pito();
            string pickupMethod = $"\nBocina: {pickUp.Pito()}";
            pickUpLabel.Text += pickupMethod;
            Informacion_Pickup = true;
        }
    }

    private void OnCounterClickedp1(object sender, EventArgs e)        //boton de encender pickup 
    {
        if (Informacion_Pickup)
        {
            Informacion_Pickup = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {

            PickUp pickUp = new PickUp();
            pickUp.Start();
            pickupMethod += $"\nEncendido: {pickUp.Start()}la mamalona";
            pickUpLabel.Text += pickupMethod;
            Informacion_Pickup = true;
        }
    }

    private void OnCounterClickedp2(object sender, EventArgs e)        //boton de apagar pickup 
    {
        if (Informacion_Pickup)
        {
            Informacion_Pickup = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {

            PickUp pickUp = new PickUp();
            pickUp.Apagar_Vehiculo();
            pickupMethod = $"\nApagado: {pickUp.Apagar_Vehiculo()}la mamalona";
            pickUpLabel.Text = pickupMethod;
            Informacion_Pickup = true;
        }
    }
    private void OnCounterClickedp3(object sender, EventArgs e)        //boton de acelerar pickup 
    {
        if (Informacion_Pickup)
        {
            Informacion_Pickup = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {

            PickUp pickUp = new PickUp();
            pickUp.Pedal_Acelerar(5);
            pickupMethod = $"\nIncrementadno  en: {pickUp.Pedal_Acelerar(25)} kmh por s";
            pickUpLabel.Text += pickupMethod;
            Informacion_Pickup = true;
        }
    }

    private void OnCounterClickedp4(object sender, EventArgs e)        //boton de frenar pickup 
    {
        if (Informacion_Pickup)
        {
            Informacion_Pickup = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {

            PickUp pickUp = new PickUp();
            pickUp.Pedal_Freno();
            pickupMethod = $"\nFrenando: de a -{pickUp.Pedal_Freno(10)}";
            pickUpLabel.Text = pickupMethod;
            Informacion_Pickup = true;
        }
    }
    private void OnCounterClickedp5(object sender, EventArgs e)        //boton de frenar pickup 
    {
        if (Informacion_Pickup)
        {
            Informacion_Pickup = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {

            PickUp pickUp = new PickUp();
            pickUp.Cargar();
            pickupMethod = "\n cargando a 1000w";
            pickUpLabel.Text = pickupMethod;
            Informacion_Pickup = true;
        }
    }
    

    private void OnCounterClicked2(object sender, EventArgs e)
    {
        if (Informacion_Camioneta)
        {
            Informacion_Camioneta = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Camioneta Camioneta = new Camioneta();
            Camioneta.Tipo_Auto = "Jeep";
            Camioneta.Modelo_Auto = "Wrangler";
            Camioneta.Color_Auto = "Negro";
            Camioneta.Año_Auto = 2023;
            Camioneta.Identificacion_Auto = "GHI789";
            Camioneta.Marca_Auto = "SUV";
            //atributos del auto caimoneta
            Camioneta.Start();
            Camioneta.Pedal_Acelerar(60);
            Camioneta.Pito();
            Camioneta.ActivarTraccion4x4();
            Camioneta.Apagar_Vehiculo();
            Camioneta.Pedal_Freno();

            string Camioneta_Info = $"Marca: {Camioneta.Tipo_Auto}" +
                $"\nModelo: {Camioneta.Modelo_Auto}" +
                $"\nColor: {Camioneta.Color_Auto}" +
                $"\nAño: {Camioneta.Año_Auto}" +
                $"\nPlaca: {Camioneta.Identificacion_Auto}" +
                $"\nTipo: {Camioneta.Marca_Auto}";
            suvLabel.Text = Camioneta_Info; // Muestra la información
           // string CamionetaMethod = $"\nBocina: {Camioneta.Pito()}";
           // CamionetaMethod += $"\nApagado: {Camioneta.Apagar_Vehiculo()}";
            //CamionetaMethod += $"\nEncendido: {Camioneta.Start()}";
            //CamionetaMethod += $"\nAcelerando en: {Camioneta.Pedal_Acelerar(5)} unidades";
            //CamionetaMethod += $"\nFrenando: de a {Camioneta.Pedal_Freno(10)}";
            //suvLabel.Text += CamionetaMethod;
            Informacion_Camioneta = true;
        }
    }

    private void OnCounterClickedc(object sender, EventArgs e)        //boton pitar camioneta 
    {
        if (Informacion_Camioneta)
        {
            Informacion_Camioneta = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Camioneta Camioneta = new Camioneta();
            Camioneta.Pito();
            string CamionetaMethod = $"\nBocina: {Camioneta.Pito()}";
            suvLabel.Text = CamionetaMethod;
            Informacion_Camioneta = true;
        }
    }

    private void OnCounterClickedc1(object sender, EventArgs e)        //boton encender camioneta 
    {
        if (Informacion_Camioneta)
        {
            Informacion_Camioneta = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Camioneta Camioneta = new Camioneta();
            Camioneta.Start();
            CamionetaMethod = $"\nEncendiendo la bestia capo: {Camioneta.Start()}";
            suvLabel.Text = CamionetaMethod;
            Informacion_Camioneta = true;
        }
    }
    private void OnCounterClickedc2(object sender, EventArgs e)        //boton apagar camioneta 
    {
        if (Informacion_Camioneta)
        {
            Informacion_Camioneta = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Camioneta Camioneta = new Camioneta();
            Camioneta.Apagar_Vehiculo();
            CamionetaMethod = $"\nApagadondo a mimir: {Camioneta.Apagar_Vehiculo()}"; 
            suvLabel.Text = CamionetaMethod;
            Informacion_Camioneta = true;
        }
    }

    private void OnCounterClickedc3(object sender, EventArgs e)        //boton acelerar  camioneta 
    {
        if (Informacion_Camioneta)
        {
            Informacion_Camioneta = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Camioneta Camioneta = new Camioneta();
            Camioneta.Pedal_Acelerar();
            CamionetaMethod = $"\nAcelerando en: {Camioneta.Pedal_Acelerar(30)} unidades";
            suvLabel.Text = CamionetaMethod;
            Informacion_Camioneta = true;
        }
    }
    private void OnCounterClickedc4(object sender, EventArgs e)        //boton frenar camioneta camioneta 
    {
        if (Informacion_Camioneta)
        {
            Informacion_Camioneta = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Camioneta Camioneta = new Camioneta();
             Camioneta.Pedal_Freno();
            CamionetaMethod += $"\nFrenando: de a - {Camioneta.Pedal_Freno(10)}";
            suvLabel.Text = CamionetaMethod;
            Informacion_Camioneta = true;
        }
    }


    private void OnCounterClicked3(object sender, EventArgs e)
    {
        if (Informacion_Jeep)
        {
            Informacion_Jeep = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Jeep Jeep = new Jeep();
            Jeep.Tipo_Auto = "Land Rover";
            Jeep.Modelo_Auto = "Defender";
            Jeep.Color_Auto = "Verde";
            Jeep.Año_Auto = 2022;
            Jeep.Identificacion_Auto = "JKL012";
            Jeep.Marca_Auto = "4x4";
        //atributos de la 4x4
            Jeep.Start();
            Jeep.Pedal_Acelerar(70);
            Jeep.Pito();
            Jeep.ConducirTerrenosDificiles();
            Jeep.Apagar_Vehiculo();
            Jeep.Pedal_Freno();

            string Jeep_Informacion = $"Marca: {Jeep.Tipo_Auto}" +
                $"\nModelo: {Jeep.Modelo_Auto}" +
                $"\nColor: {Jeep.Color_Auto}" +
                $"\nAño: {Jeep.Año_Auto}" +
                $"\nPlaca: {Jeep.Identificacion_Auto}" +
                $"\nTipo: {Jeep.Marca_Auto}";
            cuatroPorCuatroLabel.Text = Jeep_Informacion; // Muestra la información
           /* string JeepMethod = $"\nBocina: {Jeep.Pito()}";
            JeepMethod += $"\nApagado: {Jeep.Apagar_Vehiculo()}";
            JeepMethod += $"\nEncendido: {Jeep.Start()}";
            JeepMethod += $"\nAcelerando en: {Jeep.Pedal_Acelerar(5)} u";
            JeepMethod += $"\nFrenando: de a {Jeep.Pedal_Freno(10)}";*/
            //suvLabel.Text += JeepMethod;
            Informacion_Jeep = true;
        }
    }
    private void OnCounterClickedk1(object sender, EventArgs e)
    {
        if (Informacion_Jeep)
        {
            Informacion_Jeep = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Jeep Jeep = new Jeep();
            Jeep.Pito();
            string JeepMethod = $"\nBocinando: {Jeep.Pito()}";
            cuatroPorCuatroLabel.Text = Jeep_Informacion; // Muestra la información
            Informacion_Jeep = true;
        }

    }
    private void OnCounterClickedk2(object sender, EventArgs e)
    {
        if (Informacion_Jeep)
        {
            Informacion_Jeep = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Jeep Jeep = new Jeep();
            Jeep.Start();
            JeepMethod += $"\nEncendiendo la nave: {Jeep.Start()}";
            cuatroPorCuatroLabel.Text = Jeep_Informacion; // Muestra la información
            Informacion_Jeep = true;
        }

    }

    private void OnCounterClickedk3(object sender, EventArgs e)
    {
        if (Informacion_Jeep)
        {
            Informacion_Jeep = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Jeep Jeep = new Jeep();
            Jeep.Apagar_Vehiculo();
            JeepMethod += $"\nApagando la nave : {Jeep.Apagar_Vehiculo()}";
            cuatroPorCuatroLabel.Text = Jeep_Informacion; // Muestra la información
            Informacion_Jeep = true;
        }

    }

    private void OnCounterClickedk4(object sender, EventArgs e)
    {
        if (Informacion_Jeep)
        {
            Informacion_Jeep = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Jeep Jeep = new Jeep();
            Jeep.Pedal_Acelerar(70);
            JeepMethod += $"\nAcelerando en: {Jeep.Pedal_Acelerar(5)} kmh por s";
            cuatroPorCuatroLabel.Text = Jeep_Informacion; // Muestra la información
            Informacion_Jeep = true;
        }

    }

    private void OnCounterClickedk5(object sender, EventArgs e)
    {
        if (Informacion_Jeep)
        {
            Informacion_Jeep = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Jeep Jeep = new Jeep();
            Jeep.Pedal_Freno();
            JeepMethod += $"\nFrenando de a -{Jeep.Pedal_Freno(10)}";
            cuatroPorCuatroLabel.Text = Jeep_Informacion; // Muestra la información
            Informacion_Jeep = true;
        }

    }

    private void OnCounterClickedk6(object sender, EventArgs e)
    {
        if (Informacion_Jeep)
        {
            Informacion_Jeep = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Jeep Jeep = new Jeep();
            Jeep.ConducirTerrenosDificiles();
            JeepMethod += "4x4 activada";
            cuatroPorCuatroLabel.Text = Jeep_Informacion; // Muestra la información
            Informacion_Jeep = true;
        }
    }
}
}