import { Evento } from "./Evento";
import { Palestrante } from "./Palestrante";

export interface RedeSocial {
  id: number;
  nome: string;
  uRL: string;
  eventoId?: number;
  evento: Evento;
  plaestranteId?: number;
  plaestrante: Palestrante;
}
