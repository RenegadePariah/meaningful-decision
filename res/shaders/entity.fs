#version 400 core

in vec2 pass_c;

const int col_nb=3;
uniform vec3 color[col_nb];
uniform sampler2D tex;

out vec4 out_color;

void main(void){
    vec4 composition=texture(tex,pass_c);
    out_color=vec4(clamp(color[0]*composition.x+color[1]*composition.y,0.0,1.0),1.0);
}