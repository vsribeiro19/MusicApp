import { tipoUsuario } from "../enums/tipoUsuario.enum";

export interface usuario {
    idUsuario: number,
    nome: string,
    sobrenome?: string,
    login: string,
    email:string,
    senha:string,
    instrumento: string,
    tipoUsuario: tipoUsuario
}