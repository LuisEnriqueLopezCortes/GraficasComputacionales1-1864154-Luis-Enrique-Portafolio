#version 330 core
out vec4 FragColor;

in vec2 TexCoord;

uniform sampler2D texture1;
//quite la sampler2D de la texture2 para que no apareciera la otra textura

void main()
{
    FragColor = texture(texture1, TexCoord);
}