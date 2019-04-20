import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;
  public name = "";

  public incrementCounter() {
    this.currentCount++;
  }

  public getName() {
    this.name = "D13";
  }
}
