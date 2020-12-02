namespace AulaPOOCelular.classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;
        public string mensagem;
        public bool ligacao;

        public bool MandarMensagem(){
            if(ligado == false){
                return ligado == true;
            }else{
                return ligado == false;
            }
        }

        public bool FazerLigacao(){
                    if(ligado == false){
                    return this.ligado;
                    }else{
                    return ligado == true;
                    }
        } 

        public bool Ligar(){
            return this.ligado;
        } 

        public bool Desligar(){
            if(this.ligado){
                 return this.ligado == false;
            } else {
                return this.ligado == true;
            }
        }

}
}
    
