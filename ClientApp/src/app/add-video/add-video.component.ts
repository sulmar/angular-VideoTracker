import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { VideosService } from '../videos.service';
import { Video } from '../model/video';

@Component({
  selector: 'app-add-video',
  templateUrl: './add-video.component.html',
  styleUrls: ['./add-video.component.css']
})
export class AddVideoComponent implements OnInit {

  public genres: string[];
  public video: Video = {};

  constructor(
    private router: Router,
    private videoService: VideosService) {

    this.genres = ['', 'Music', 'Comedy', 'Inspirational', 'Tech', 'News', 'Sports'];
  }

  ngOnInit() {
  }

  addVideo() {
    this.videoService.addVideo(this.video)
      .subscribe(() => {
        this.router.navigateByUrl('/'); });
    }
}
