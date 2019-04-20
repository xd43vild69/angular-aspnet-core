import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { IPersona } from '../persona';
import { PersonasService } from '../personas.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-persona-form',
  templateUrl: './persona-form.component.html',
  styleUrls: ['./persona-form.component.css']
})
export class PersonaFormComponent implements OnInit {

  constructor(private fb: FormBuilder,
    private personaService: PersonasService,
    private router: Router) { }

  // Conjunto de Valores correspondientes con el formulario en la vista
  formGroup: FormGroup;

  ngOnInit() {
    //Crear modelo basico para el formulario
    this.formGroup = this.fb.group({
      nombre: '',
      fechaNacimiento:''
    });
  }

  save() {
    // crear una persona apartir del formgroup
    let persona: IPersona = Object.assign({}, this.formGroup.value);
    console.log(persona);
    this.personaService.createPersona(persona)
      .subscribe(persona => this.OnSaveSuccess(),
        error => console.error(error));
  }

  OnSaveSuccess() {
    //Navegacion desde el codigo injectamos Router en el constructor.
    this.router.navigate(["/persona"]);
  }

}
