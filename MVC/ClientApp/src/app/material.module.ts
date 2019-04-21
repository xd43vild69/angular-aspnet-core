// material.module.ts

import { NgModule } from '@angular/core';
import {
  MatDatepickerModule,
  MatNativeDateModule,
  MatFormFieldModule,
  MatInputModule,
} from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from '@angular/material/toolbar';

@NgModule({
  imports: [
    MatDatepickerModule,
    MatFormFieldModule,
    MatNativeDateModule,
    MatInputModule,
    BrowserAnimationsModule,
    MatToolbarModule
  ],
  exports: [
    MatDatepickerModule,
    MatFormFieldModule,
    MatNativeDateModule,
    MatInputModule,
    BrowserAnimationsModule,
    MatToolbarModule
  ],
  providers: [MatDatepickerModule],
})

export class MaterialModule { }
