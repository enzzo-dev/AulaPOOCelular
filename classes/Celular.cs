namespace AulaPOOCelular.classes
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;
        public string mensagem;
        public string ligacao;

        public bool MandarMensagem(){
            if(ligado == false){
                return ligado == true;
            }else{
                return ligado;
            }
        }

        public bool FazerLigacao(){
                    if(ligado == false){
                    return this.ligado;
                    }else{
                    return this.ligado == true;
                    }
        } 

        public bool Ligar(){
            return this.ligado;
        } 

}
}
    
