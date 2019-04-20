import { Component, OnInit } from '@angular/core';
import { IPersona } from './persona';
import { PersonasService } from './personas.service';
@Component({
  selector: 'app-persona',
  templateUrl: './persona.component.html',
  styleUrls: ['./persona.component.css']
})
export class PersonaComponent implements OnInit {

  personas: IPersona[];

  constructor(private personaService: PersonasService) { }

  ngOnInit() {
    this.personaService.getPersonas()
      .subscribe(personaDesdeWS => this.personas = personaDesdeWS,
        error => console.log(error));
  }

}
