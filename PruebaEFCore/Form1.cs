using AutoMapper;
using PruebaEFCore.Domain.Intefaces;
using PruebaEFCore.Domain.Model;
using PruebaEFCore.ViewModel;

namespace PruebaEFCore
{
    public partial class Form1 : Form
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public Form1(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerListadoBlog();
        }

        private void CreateAndSaveBlog()
        {
            var dateString = DateTime.Now.ToString("G");
            var blog = new BlogViewModel
            {
                Title = $"Blog del {dateString}",
                SubTitle = $"Subtitulo del Blog del {dateString}"
            };

            _blogService.Create(_mapper.Map<BlogDto>(blog));
        }

        private void LeerListadoBlog()
        {
            blogViewModelBindingSource.DataSource = _blogService.GetAll().Select(b => _mapper.Map<BlogViewModel>(b)).ToList();
        }

        private BlogViewModel LeerModeloDesdeControles()
        {
            var newBlog = new BlogViewModel()
            {
                BlogId = string.IsNullOrWhiteSpace(idTextBox.Text) ? 0 : int.Parse(idTextBox.Text),
                Title = string.IsNullOrWhiteSpace(titleTextBox.Text) ? "Sin título" : titleTextBox.Text,
                SubTitle = string.IsNullOrWhiteSpace(subtitleTextBox.Text) ? "Sin subtítulo" : subtitleTextBox.Text
            };
            return newBlog;
        }

        private void BorrarModeloEnControles()
        {
            idTextBox.Text = string.Empty;
            titleTextBox.Text = string.Empty;
            subtitleTextBox.Text = string.Empty;

            btnEliminar.Enabled = true;
        }

        private void EscribirModeloEnControles(BlogViewModel blogViewModel)
        {
            idTextBox.Text = blogViewModel.BlogId.ToString();
            titleTextBox.Text = blogViewModel.Title;
            subtitleTextBox.Text = blogViewModel.SubTitle;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = !(string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(subtitleTextBox.Text));
            btnLimpiar.Enabled = !(string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(subtitleTextBox.Text));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var newBlog = LeerModeloDesdeControles();

                var isNew = newBlog.BlogId == 0;

                if (isNew)
                    _blogService.Create(_mapper.Map<BlogDto>(newBlog));
                else
                    _blogService.Update(_mapper.Map<BlogDto>(newBlog));

                LeerListadoBlog();

                if (isNew)
                    blogViewModelBindingSource.Position = blogViewModelBindingSource.Count - 1;

                MessageBox.Show("Se ha guardado el registro correctamente.");
                BorrarModeloEnControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Se ha producido un error:\r\n{exception.Message}");
                BorrarModeloEnControles();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (blogViewModelBindingSource.Current is not BlogViewModel blogViewModel) return;

            EscribirModeloEnControles(blogViewModel);
            btnEliminar.Enabled = false;
        }

        private void btnAddRegister_Click(object sender, EventArgs e)
        {
            CreateAndSaveBlog();
            LeerListadoBlog();
            blogViewModelBindingSource.Position = blogViewModelBindingSource.Count - 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (blogViewModelBindingSource.Current is not BlogViewModel blogViewModel) return;

            if (MessageBox.Show($"¿Está seguro que quiere borrar el Blog \"{blogViewModel.Title}\"") == DialogResult.No)
                return;

            _blogService.Remove(_mapper.Map<BlogDto>(blogViewModel));

            LeerListadoBlog();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarModeloEnControles();
        }
    }
}