import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonaFormComponent } from './persona-form.component';

describe('PersonaFormComponent', () => {
  let component: PersonaFormComponent;
  let fixture: ComponentFixture<PersonaFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PersonaFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonaFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
