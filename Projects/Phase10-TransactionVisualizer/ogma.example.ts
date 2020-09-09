import { map } from 'rxjs/operators';
import { Component, OnInit } from '@angular/core';
import * as Ogma from '../../assets/ogma.min.js';

@Component({
  selector: 'app-graph',
  templateUrl: './graph.component.html',
  styleUrls: ['./graph.component.css']
})
export class GraphComponent implements OnInit {
  private ogma: Ogma;
  private nodes = [];
  private links = [];
  private nodesMaxCount = 10;
  private nodesCount: number;
  private linksCount: number;
  private width: number;
  private height: number;


  constructor() {
  }

  ngOnInit(): void {

    this.initOgma();

  }

  private initOgma(): void {
    this.ogma = new Ogma({
      container: 'graph-container',
    });

    this.width = this.ogma.getContainer().offsetWidth;
    this.height = this.ogma.getContainer().offsetHeight;
    // graph-container width and height

    this.nodesCount = Math.floor(Math.random() * this.nodesMaxCount) + 1;
    this.linksCount = Math.floor(Math.random() * this.nodesMaxCount);
    // random nodes count and links count

    // creating nodes
    this.nodes = [];
    for (let i = 0; i < this.nodesCount; i++) {
      const randomX = Math.random() * this.width - this.width / 2;
      const randomY = Math.random() * this.height - this.height / 2;

      this.nodes.push(
        { id: 'n' + i, data: { name: 'Node ' + i }, attributes: { x: randomX, y: randomY, radius: 20 } }
      ); // data is a custom dictionary for containing data
    }

    this.ogma.addNodes(this.nodes);
    // adding created nodes to ogma


    // creating links
    this.links = [];
    for (let i = 0; i < this.linksCount; i++) {

      const sourceId = 'n' + (Math.floor(Math.random() * this.nodesCount));
      const targetId = 'n' + (Math.floor(Math.random() * this.nodesCount));

      if (sourceId === targetId && this.nodesCount !== 1) {
        i--;
        continue;
      }

      this.links.push(
        { id: 'e' + i, source: sourceId, target: targetId, data: { name: 'parent' } }
      ); // data is a custom dictionary for containing data
    }

    this.ogma.addEdges(this.links);
    // adding created links to ogma
  }
}
