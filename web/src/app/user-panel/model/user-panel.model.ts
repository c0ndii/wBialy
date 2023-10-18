export interface PostToAdd{
  postId:number;
  title: string;
  description: string;
  image: string;
  place: string;
  eventDate: string;
  tags: Tags[];
  link: string;
}
export interface Tags{
  name: string;
}
