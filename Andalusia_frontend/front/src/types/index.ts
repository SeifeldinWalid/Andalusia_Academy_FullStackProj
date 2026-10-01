export interface Course {
  id: number;
  title: string;
  imageUrl: string | null;
  price: number;
  categoryName: string | null;
}

export interface Category {
  id: number;
  name: string;
  courseCount: number;
}

export interface Partner {
  id: number;
  name: string;
  logoUrl: string;
}

export interface Testimonial {
  id: number;
  authorName: string;
  role: string;
  content: string;
  avatarUrl: string | null;
}

export interface Homepage {
  heroTitle: string;
  heroSubtitle: string;
  heroImageUrl: string | null;
  corporateTitle: string;
  corporateDescription: string;
  comingSoonText: string;
  featuredCourses: Course[];
  popularCategories: Category[];
  partners: Partner[];
  testimonials: Testimonial[];
}