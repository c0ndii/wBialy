export interface EventPost{
  //public PostId: number;
  postId: number;
  title: string;
  description: string;
  image: string;
  place: string;
  eventDate: string;
  confirmed: boolean;
  day: string;
  tags: string[]
  link: string;
}
