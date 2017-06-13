S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 14613
Date: 2017-06-13 13:59:19+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb285265a

Register Information
r0   = 0xb9212a10, r1   = 0xb920e948
r2   = 0xb920e948, r3   = 0xb9212a10
r4   = 0xb4041a3c, r5   = 0xbe8a8484
r6   = 0x00000001, r7   = 0xbe8a8348
r8   = 0xbe8a8478, r9   = 0xb905f0e0
r10  = 0xbe8a8498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbe8a82ec
lr   = 0xb28525d7, pc   = 0xb285265a
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     67244 KB
Buffers:     60984 KB
Cached:     225408 KB
VmPeak:      90468 KB
VmSize:      90464 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19544 KB
VmRSS:       19544 KB
VmData:      22012 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14613 TID = 14613
14613 14623 15195 

Maps Information
b1c03000 b1c0b000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1c1c000 b1c1d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c2d000 b1c41000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c55000 b1c56000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c66000 b1c69000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c7a000 b1c7b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c8b000 b1c8d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c9d000 b1c9f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1caf000 b1cbf000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1ccf000 b1cdb000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ced000 b24ec000 rw-p [stack:15195]
b281d000 b2824000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2837000 b283d000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b284d000 b287d000 r-xp /opt/usr/apps/org.example.client/bin/client
b29c6000 b2aa9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ae0000 b2b08000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b1a000 b3319000 rw-p [stack:14623]
b3319000 b331b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b332b000 b3335000 r-xp /lib/libnss_files-2.20-2014.11.so
b3346000 b334f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3360000 b3371000 r-xp /lib/libnsl-2.20-2014.11.so
b3384000 b338a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b339b000 b339c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33c4000 b33cb000 r-xp /usr/lib/libminizip.so.1.0.0
b33db000 b33e0000 r-xp /usr/lib/libstorage.so.0.1
b33f0000 b344f000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3465000 b3479000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3489000 b34cd000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34dd000 b34e5000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34f5000 b3525000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3538000 b35f1000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3605000 b3658000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3669000 b3684000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3694000 b3755000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3768000 b3778000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3788000 b3795000 r-xp /usr/lib/libmdm-common.so.1.0.98
b37a6000 b37ad000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37bd000 b37fe000 r-xp /usr/lib/libmdm.so.1.2.12
b380e000 b3816000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3825000 b3835000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3856000 b38b6000 r-xp /usr/lib/libasound.so.2.0.0
b38c8000 b38cb000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38db000 b38de000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38ee000 b38f3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3903000 b3904000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3914000 b391f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3933000 b393a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b394a000 b3950000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3960000 b3965000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3975000 b3990000 r-xp /usr/lib/libmmfsound.so.0.1.0
b39a0000 b39a7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39b7000 b39ba000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39cb000 b39f9000 r-xp /usr/lib/libidn.so.11.5.44
b3a09000 b3a1f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a30000 b3a3a000 r-xp /usr/lib/libcares.so.2.1.0
b3a4a000 b3a54000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a64000 b3a66000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a76000 b3a77000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a87000 b3a8b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a9c000 b3ac4000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ad5000 b3afe000 r-xp /usr/lib/libturbojpeg.so
b3b1e000 b3b24000 r-xp /usr/lib/libgif.so.4.1.6
b3b34000 b3b7a000 r-xp /usr/lib/libcurl.so.4.3.0
b3b8b000 b3bac000 r-xp /usr/lib/libexif.so.12.3.3
b3bc7000 b3bdc000 r-xp /usr/lib/libtts.so
b3bed000 b3bf5000 r-xp /usr/lib/libfeedback.so.0.1.4
b3c05000 b3ccb000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ceb000 b3de3000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3e02000 b3ed0000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ee7000 b3ee9000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ef9000 b3eff000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f0f000 b3f32000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f43000 b3f45000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f55000 b3f57000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f68000 b3f6d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f84000 b3f86000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f96000 b3f9d000 r-xp /usr/lib/libsensord-share.so
b3fad000 b3fc5000 r-xp /usr/lib/libsensor.so.1.1.0
b3fd6000 b3fd9000 r-xp /usr/lib/libXv.so.1.0.0
b3fe9000 b3fee000 r-xp /usr/lib/libutilX.so.1.1.0
b3ffe000 b4003000 r-xp /usr/lib/libappcore-common.so.1.1
b4013000 b401a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b402d000 b4031000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4042000 b4120000 r-xp /usr/lib/libCOREGL.so.4.0
b4140000 b4143000 r-xp /usr/lib/libuuid.so.1.3.0
b4153000 b416a000 r-xp /usr/lib/libblkid.so.1.1.0
b417b000 b417d000 r-xp /usr/lib/libXau.so.6.0.0
b418d000 b41d4000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41e6000 b41ec000 r-xp /usr/lib/libjson-c.so.2.0.1
b41fd000 b4201000 r-xp /usr/lib/libogg.so.0.7.1
b4211000 b4233000 r-xp /usr/lib/libvorbis.so.0.4.3
b4243000 b4327000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4343000 b4346000 r-xp /usr/lib/libEGL.so.1.4
b4357000 b435d000 r-xp /usr/lib/libxcb-render.so.0.0.0
b436d000 b436f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b437f000 b438c000 r-xp /usr/lib/libGLESv2.so.2.0
b439d000 b43ff000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4414000 b442c000 r-xp /usr/lib/libmount.so.1.1.0
b443e000 b4452000 r-xp /usr/lib/libxcb.so.1.1.0
b4462000 b4469000 r-xp /lib/libcrypt-2.20-2014.11.so
b44a1000 b44a3000 r-xp /usr/lib/libiri.so
b44b3000 b44be000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44cf000 b4505000 r-xp /usr/lib/libpulse.so.0.16.2
b4516000 b4559000 r-xp /usr/lib/libsndfile.so.1.0.25
b456e000 b4583000 r-xp /lib/libexpat.so.1.5.2
b4595000 b4653000 r-xp /usr/lib/libcairo.so.2.11200.14
b4667000 b466f000 r-xp /usr/lib/libdrm.so.2.4.0
b467f000 b4682000 r-xp /usr/lib/libdri2.so.0.0.0
b4692000 b46e0000 r-xp /usr/lib/libssl.so.1.0.0
b46f5000 b4701000 r-xp /usr/lib/libeeze.so.1.13.0
b4712000 b471b000 r-xp /usr/lib/libethumb.so.1.13.0
b472b000 b472e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b473e000 b48f5000 r-xp /usr/lib/libcrypto.so.1.0.0
b56e0000 b56e9000 r-xp /usr/lib/libXi.so.6.1.0
b56f9000 b56fb000 r-xp /usr/lib/libXgesture.so.7.0.0
b570b000 b570f000 r-xp /usr/lib/libXtst.so.6.1.0
b571f000 b5725000 r-xp /usr/lib/libXrender.so.1.3.0
b5735000 b573b000 r-xp /usr/lib/libXrandr.so.2.2.0
b574b000 b574d000 r-xp /usr/lib/libXinerama.so.1.0.0
b575e000 b5761000 r-xp /usr/lib/libXfixes.so.3.1.0
b5771000 b577c000 r-xp /usr/lib/libXext.so.6.4.0
b578c000 b578e000 r-xp /usr/lib/libXdamage.so.1.1.0
b579e000 b57a0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57b0000 b5892000 r-xp /usr/lib/libX11.so.6.3.0
b58a6000 b58ad000 r-xp /usr/lib/libXcursor.so.1.0.2
b58bd000 b58d5000 r-xp /usr/lib/libudev.so.1.6.0
b58d7000 b58da000 r-xp /lib/libattr.so.1.1.0
b58ea000 b590a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b590b000 b5910000 r-xp /usr/lib/libffi.so.6.0.2
b5921000 b5939000 r-xp /lib/libz.so.1.2.8
b5949000 b594b000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b595b000 b5a30000 r-xp /usr/lib/libxml2.so.2.9.2
b5a45000 b5ae0000 r-xp /usr/lib/libstdc++.so.6.0.20
b5afc000 b5aff000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b0f000 b5b28000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b39000 b5b4a000 r-xp /lib/libresolv-2.20-2014.11.so
b5b5e000 b5bd8000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bed000 b5bef000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bff000 b5c06000 r-xp /usr/lib/libembryo.so.1.13.0
b5c16000 b5c20000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c31000 b5c49000 r-xp /usr/lib/libpng12.so.0.50.0
b5c5a000 b5c7d000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c9e000 b5cb2000 r-xp /usr/lib/libector.so.1.13.0
b5cc3000 b5cdb000 r-xp /usr/lib/liblua-5.1.so
b5cec000 b5d43000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d57000 b5d7f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d90000 b5da3000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db4000 b5dee000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dff000 b5e0d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e1d000 b5e25000 r-xp /usr/lib/libtbm.so.1.0.0
b5e35000 b5e42000 r-xp /usr/lib/libeio.so.1.13.0
b5e52000 b5e54000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e64000 b5e69000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e79000 b5e90000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea2000 b5ec2000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed2000 b5ef2000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ef4000 b5efa000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f0a000 b5f1b000 r-xp /usr/lib/libemotion.so.1.13.0
b5f2c000 b5f33000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f43000 b5f52000 r-xp /usr/lib/libeo.so.1.13.0
b5f63000 b5f75000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f86000 b5f8b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f9b000 b5fb4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fc4000 b5fe1000 r-xp /usr/lib/libeet.so.1.13.0
b5ffa000 b6042000 r-xp /usr/lib/libeina.so.1.13.0
b6053000 b6063000 r-xp /usr/lib/libefl.so.1.13.0
b6074000 b6159000 r-xp /usr/lib/libicuuc.so.51.1
b6176000 b62b6000 r-xp /usr/lib/libicui18n.so.51.1
b62cd000 b6305000 r-xp /usr/lib/libecore_x.so.1.13.0
b6317000 b631a000 r-xp /lib/libcap.so.2.21
b632a000 b6353000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6364000 b636b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b637d000 b63b4000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63c5000 b64b0000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64c3000 b653c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b654e000 b6553000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6563000 b656d000 r-xp /usr/lib/libvconf.so.0.2.45
b657d000 b657f000 r-xp /usr/lib/libvasum.so.0.3.1
b658f000 b6591000 r-xp /usr/lib/libttrace.so.1.1
b65a1000 b65a4000 r-xp /usr/lib/libiniparser.so.0
b65b4000 b65da000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65ea000 b65ef000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6600000 b6617000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6628000 b6693000 r-xp /lib/libm-2.20-2014.11.so
b66a4000 b66aa000 r-xp /lib/librt-2.20-2014.11.so
b66bb000 b66c8000 r-xp /usr/lib/libunwind.so.8.0.1
b66fe000 b6822000 r-xp /lib/libc-2.20-2014.11.so
b6837000 b6850000 r-xp /lib/libgcc_s-4.9.so.1
b6860000 b6942000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6953000 b697d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b698e000 b69ca000 r-xp /usr/lib/libsystemd.so.0.4.0
b69cc000 b6a4f000 r-xp /usr/lib/libedje.so.1.13.0
b6a62000 b6a80000 r-xp /usr/lib/libecore.so.1.13.0
b6aa0000 b6c27000 r-xp /usr/lib/libevas.so.1.13.0
b6c5c000 b6c70000 r-xp /lib/libpthread-2.20-2014.11.so
b6c84000 b6eb8000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee7000 b6eeb000 r-xp /usr/lib/libsmack.so.1.0.0
b6efb000 b6f02000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f12000 b6f14000 r-xp /usr/lib/libdlog.so.0.0.0
b6f24000 b6f27000 r-xp /usr/lib/libbundle.so.0.1.22
b6f37000 b6f39000 r-xp /lib/libdl-2.20-2014.11.so
b6f4a000 b6f62000 r-xp /usr/lib/libaul.so.0.1.0
b6f76000 b6f7b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f8c000 b6f99000 r-xp /usr/lib/liblptcp.so
b6fab000 b6faf000 r-xp /usr/lib/libsys-assert.so
b6fc0000 b6fe0000 r-xp /lib/ld-2.20-2014.11.so
b6ff1000 b6ff6000 r-xp /usr/bin/launchpad-loader
b8ffa000 b923f000 rw-p [heap]
be888000 be8a9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14613)
Call Stack Count: 13
 0: $d.51 + 0x0 (0xb285265a) [/opt/usr/apps/org.example.client/bin/client] + 0x565a
 1:  + 0x0 (0xb28525d7) [/opt/usr/apps/org.example.client/bin/client] + 0x55d7
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb28523a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb286b5db) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5db
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb286b751) [/opt/usr/apps/org.example.client/bin/client] + 0x1e751
 5: (0xb402f4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6f79203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb402f909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb286badb) [/opt/usr/apps/org.example.client/bin/client] + 0x1eadb
 9: main + 0x40 (0xb2852129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: (0xb6ff2bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb67144bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6ff2eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
06-13 13:57:23.064+0900 I/AUL_AMD (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/sbin/connmand, ret : 0
06-13 13:57:23.064+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 38
06-13 13:57:23.064+0900 E/AUL_AMD (  607): amd_status.c: _status_get_cmdline(1204) > cmdline : /usr/sbin/connmand
06-13 13:57:23.064+0900 E/AUL_AMD (  607): amd_status.c: _status_get_cmdline(1207) > pkt->data : /usr/sbin/connmand
06-13 13:57:23.064+0900 E/ALARM_MANAGER(  630): alarm-manager-schedule.c: __alarm_next_duetime_once(152) > Final due_time = 1497330293, Tue Jun 13 14:04:53 2017
06-13 13:57:23.064+0900 E/ALARM_MANAGER(  630): alarm-manager-schedule.c: _alarm_next_duetime(502) > alarm_id: 1560857485, next duetime: 1497330293
06-13 13:57:23.064+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_add_to_list(562) > [alarm-server]: After add alarm_id(1560857485)
06-13 13:57:23.064+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __alarm_create(1183) > [alarm-server]:alarm_context.c_due_time(1497330173), due_time(1497330293)
06-13 13:57:23.064+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(237) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-13 13:57:23.064+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(244) > Setted RTC Alarm date/time is 13-6-2017, 05:02:53 (UTC).
06-13 13:57:23.064+0900 E/ALARM_MANAGER(  630): alarm-manager.c: __rtc_set(259) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-13 13:59:02.040+0900 E/PKGMGR_SERVER(14975): pkgmgr-server.c: main(2414) > package manager server start
06-13 13:59:02.130+0900 E/PKGMGR  (14973): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
06-13 13:59:02.190+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
06-13 13:59:02.190+0900 E/AUL_AMD (  607): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 14824
06-13 13:59:02.200+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-13 13:59:02.210+0900 E/PKGMGR_SERVER(14975): pkgmgr-server.c: sighandler(417) > child NORMAL exit [14978]
06-13 13:59:04.793+0900 E/PKGMGR_SERVER(14975): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 13:59:04.793+0900 E/PKGMGR_SERVER(14975): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 13:59:05.213+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-13 13:59:05.213+0900 W/LOCKSCREEN(  857): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-13 13:59:05.213+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-13 13:59:05.213+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-13 13:59:05.213+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-13 13:59:05.213+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-13 13:59:05.223+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 13:59:05.233+0900 E/LOCKSCREEN(  857): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-13 13:59:05.233+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 13:59:05.233+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 1:59
06-13 13:59:05.233+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 1:59"
06-13 13:59:05.233+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 1:59"
06-13 13:59:05.233+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 13:59:05.233+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147112002 Time: <font_size=31> </font_size> <font_size=31> 오후 1:59</font_size></font>"
06-13 13:59:05.233+0900 I/INDICATOR(  665): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
06-13 13:59:05.233+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-13 13:59:05.233+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 13:59:05.233+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 13:59:05.233+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 13:59:05.243+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 13:59:05.243+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 13:59:05.243+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 13:59:05.444+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-13 13:59:05.444+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-13 13:59:05.444+0900 W/APP_CORE(  857): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-13 13:59:05.444+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: RESUME State: PAUSED
06-13 13:59:05.444+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:59:05.444+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-13 13:59:05.444+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-13 13:59:05.444+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 13:59:05.454+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-13 13:59:05.454+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:05.454+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 857
06-13 13:59:05.454+0900 I/AUL_AMD (  607): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-13 13:59:05.464+0900 W/AUL_AMD (  607): amd_launch.c: start_process(638) > child process: 15027
06-13 13:59:05.464+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:59:05.514+0900 W/AUL_AMD (  607): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 15027
06-13 13:59:05.514+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 15027, appid: com.samsung.weather-m-agent
06-13 13:59:05.534+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(425) > request cmd(0) result(15027)
06-13 13:59:05.564+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-13 13:59:05.564+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 15027.
06-13 13:59:05.714+0900 E/weather-agent(15027): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-13 13:59:05.714+0900 E/weather-common(15027): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-13 13:59:05.714+0900 E/weather-agent(15027): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-13 13:59:05.714+0900 E/weather-common(15027): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-13 13:59:05.714+0900 E/weather-common(15027): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-13 13:59:05.714+0900 E/weather-common(15027): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-13 13:59:05.714+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-13 13:59:05.714+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-13 13:59:05.714+0900 I/MESSAGE_PORT(15027): message-port.c: __initialize(872) > initialize
06-13 13:59:05.724+0900 I/MESSAGE_PORT(15027): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-13 13:59:05.754+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 13:59:05.754+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 13:59:05.754+0900 I/MESSAGE_PORT(15027): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 13:59:05.754+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-13 13:59:05.754+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-13 13:59:05.754+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 13:59:05.754+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 13:59:05.754+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-13 13:59:05.754+0900 I/MESSAGE_PORT(  857): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 13:59:05.764+0900 E/MESSAGE_PORT(15027): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 13:59:05.764+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 13:59:05.764+0900 I/MESSAGE_PORT( 1324): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 13:59:05.764+0900 E/MESSAGE_PORT(15027): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-13 13:59:05.764+0900 E/weather-common(15027): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-13 13:59:05.764+0900 E/weather-agent(15027): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-13 13:59:05.764+0900 E/weather-agent(15027): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 13:59:05.764+0900 I/MESSAGE_PORT(15027): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 13:59:05.774+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:59:05.794+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:59:05.834+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 13:59:05.834+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 13:59:05.834+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:05.834+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:05.834+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 13:59:05.844+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 13:59:05.844+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_update_cb(287) > received updating signal
06-13 13:59:05.854+0900 I/Tizen::System( 1175): (280) > The screen has been turned on.
06-13 13:59:05.854+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:59:05.874+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:59:05.874+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-13 13:59:05.914+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 13:59:05.914+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 13:59:06.765+0900 E/weather-agent(15027): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-13 13:59:06.765+0900 I/CAPI_APPFW_APPLICATION(15027): service_app_main.c: service_app_exit(446) > service_app_exit
06-13 13:59:06.775+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 13:59:06.775+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 13:59:06.775+0900 E/weather-agent(15027): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-13 13:59:06.915+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 13:59:06.915+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 15027
06-13 13:59:06.915+0900 I/Tizen::App( 1175): (243) > App[com.samsung.weather-m-agent] pid[15027] terminate event is forwarded
06-13 13:59:06.915+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 13:59:06.915+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 15027, ]
06-13 13:59:06.915+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 13:59:06.915+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-13 13:59:06.915+0900 I/Tizen::App( 1175): (512) > Not registered pid(15027)
06-13 13:59:06.915+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.weather-m-agent]
06-13 13:59:06.915+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 13:59:06.915+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 15027
06-13 13:59:06.925+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 13:59:06.925+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 15027.
06-13 13:59:07.035+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16933241
06-13 13:59:07.065+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16933274
06-13 13:59:07.065+0900 E/LOCKSCREEN(  857): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-13 13:59:07.075+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 13:59:07.145+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=16933341
06-13 13:59:07.295+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=16933508
06-13 13:59:07.295+0900 E/LOCKSCREEN(  857): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-13 13:59:07.295+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-13 13:59:07.295+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-13 13:59:07.295+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 13:59:07.295+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-13 13:59:07.295+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-13 13:59:07.295+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-13 13:59:07.295+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-13 13:59:07.295+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-13 13:59:07.305+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-13 13:59:07.305+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 13:59:07.305+0900 E/PKGMGR  (15073): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
06-13 13:59:07.395+0900 E/PKGMGR_SERVER(15075): pkgmgr-server.c: main(2414) > package manager server start
06-13 13:59:07.465+0900 E/PKGMGR_SERVER(15075): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
06-13 13:59:07.475+0900 E/PKGMGR_SERVER(15075): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
06-13 13:59:07.475+0900 E/PKGMGR  (15073): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[150730002]
06-13 13:59:07.636+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-13 13:59:07.636+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-13 13:59:07.636+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-13 13:59:07.636+0900 E/LOCKSCREEN(  857): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-13 13:59:07.636+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 13:59:07.636+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 13:59:07.636+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 13:59:07.636+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 13:59:07.636+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 13:59:07.636+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:07.646+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:59:07.646+0900 I/APP_CORE(14656): appcore-efl.c: __do_app(514) > [APP 14656] Event: RESUME State: PAUSED
06-13 13:59:07.646+0900 I/CAPI_APPFW_APPLICATION(14656): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 13:59:07.656+0900 W/LOCKSCREEN(  857): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-13 13:59:07.656+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-13 13:59:07.656+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-13 13:59:07.656+0900 E/LOCKSCREEN(  857): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-13 13:59:07.656+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: PAUSE State: RUNNING
06-13 13:59:07.656+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 13:59:07.656+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 13:59:07.656+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 13:59:07.656+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-13 13:59:07.656+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-13 13:59:07.656+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 13:59:07.656+0900 E/LOCKSCREEN(  857): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-13 13:59:07.666+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(857) status(4)
06-13 13:59:07.666+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(857)
06-13 13:59:07.666+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 857, appid: com.samsung.lockscreen, status: bg
06-13 13:59:07.666+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(14656) status(3)
06-13 13:59:07.666+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:59:07.666+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 13:59:07.666+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.myfile-lite(14656)
06-13 13:59:07.666+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14656, appid: com.samsung.myfile-lite, status: fg
06-13 13:59:07.666+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 13:59:07.676+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 13:59:07.676+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 13:59:07.676+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
06-13 13:59:07.676+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [96]
06-13 13:59:07.686+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:07.686+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:07.686+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-13 13:59:07.696+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 13:59:07.696+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 13:59:07.696+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 13:59:07.696+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-13 13:59:07.696+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:07.696+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:07.756+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-13 13:59:07.756+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 13:59:07.756+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 13:59:07.756+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 13:59:07.756+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 13:59:07.756+0900 E/LOCKSCREEN(  857): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-13 13:59:07.966+0900 E/rpm-installer(15078): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
06-13 13:59:07.966+0900 E/rpm-installer(15078): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
06-13 13:59:08.016+0900 E/PKGMGR_PARSER(15078): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-13 13:59:08.036+0900 I/PRIVACY-MANAGER-CLIENT(15078): SocketClient.cpp: SocketClient(37) > Client created
06-13 13:59:08.036+0900 I/PRIVACY-MANAGER-CLIENT(15078): SocketClient.cpp: connect(62) > Client connected
06-13 13:59:08.036+0900 I/PRIVACY-MANAGER-SERVER(  914): SocketService.cpp: mainloop(230) > Got incoming connection
06-13 13:59:08.036+0900 I/PRIVACY-MANAGER-CLIENT(15078): SocketClient.cpp: disconnect(72) > Client disconnected
06-13 13:59:08.046+0900 E/PKGMGR_CERT(15078): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-13 13:59:08.046+0900 E/PKGMGR_CERT(15078): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-13 13:59:08.056+0900 E/PKGMGR_CERT(15078): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-13 13:59:08.086+0900 E/rpm-installer(15078): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
06-13 13:59:08.086+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:08.086+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
06-13 13:59:08.086+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:08.086+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
06-13 13:59:08.096+0900 E/ESD     (  898): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
06-13 13:59:08.096+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
06-13 13:59:08.106+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
06-13 13:59:08.106+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
06-13 13:59:09.748+0900 E/PKGMGR_SERVER(15075): pkgmgr-server.c: sighandler(417) > child NORMAL exit [15078]
06-13 13:59:09.788+0900 E/PKGMGR_SERVER(15075): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 13:59:09.788+0900 E/PKGMGR_SERVER(15075): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 13:59:11.770+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 13:59:12.130+0900 E/PKGMGR  (15128): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-13 13:59:12.210+0900 E/PKGMGR_SERVER(15130): pkgmgr-server.c: main(2414) > package manager server start
06-13 13:59:12.260+0900 E/PKGMGR_SERVER(15130): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
06-13 13:59:12.270+0900 E/PKGMGR_INFO(15130): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
06-13 13:59:12.280+0900 E/rpm-installer(15130): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-13 13:59:12.290+0900 E/PKGMGR_SERVER(15130): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-13 13:59:12.290+0900 E/PKGMGR  (15128): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[151280002]
06-13 13:59:12.410+0900 E/PKGMGR_INSTALLER(15133): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-13 13:59:12.410+0900 E/rpm-installer(15133): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
06-13 13:59:12.430+0900 E/rpm-installer(15133): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-13 13:59:12.430+0900 E/rpm-installer(15133): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-13 13:59:12.430+0900 E/rpm-installer(15133): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 13:59:12.430+0900 E/rpm-installer(15133): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-13 13:59:12.430+0900 E/rpm-installer(15133): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 13:59:12.530+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
06-13 13:59:12.530+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
06-13 13:59:12.530+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:12.530+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:12.540+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
06-13 13:59:12.540+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [30]
06-13 13:59:12.540+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
06-13 13:59:12.540+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:12.540+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:12.651+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 13:59:12.821+0900 E/rpm-installer(15133): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-13 13:59:12.821+0900 E/rpm-installer(15133): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-13 13:59:12.821+0900 E/rpm-installer(15133): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-13 13:59:12.821+0900 E/rpm-installer(15133): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-13 13:59:12.821+0900 E/rpm-installer(15133): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-13 13:59:12.821+0900 E/rpm-installer(15133): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-13 13:59:12.831+0900 E/PKGMGR_PARSER(15133): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-13 13:59:12.831+0900 E/PKGMGR_PARSER(15133): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-13 13:59:12.871+0900 I/PRIVACY-MANAGER-CLIENT(15133): SocketClient.cpp: SocketClient(37) > Client created
06-13 13:59:13.091+0900 E/PKGMGR_PARSER(15133): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-13 13:59:13.111+0900 E/PKGMGR_CERT(15133): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-13 13:59:13.111+0900 E/PKGMGR_CERT(15133): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-13 13:59:13.111+0900 E/PKGMGR_CERT(15133): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-13 13:59:13.111+0900 E/PKGMGR_CERT(15133): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 1
06-13 13:59:13.111+0900 E/PKGMGR_CERT(15133): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 38 2
06-13 13:59:13.111+0900 E/PKGMGR_CERT(15133): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 39 2
06-13 13:59:13.111+0900 E/PKGMGR_CERT(15133): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 1
06-13 13:59:13.121+0900 E/PKGMGR_CERT(15133): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-13 13:59:13.121+0900 E/rpm-installer(15133): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.client/lib]
06-13 13:59:13.131+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:13.131+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:13.131+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
06-13 13:59:13.131+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [60]
06-13 13:59:13.131+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
06-13 13:59:13.141+0900 E/rpm-installer(15133): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-13 13:59:13.161+0900 E/rpm-installer(15133): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-13 13:59:13.161+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:13.161+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
06-13 13:59:13.161+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:13.161+0900 I/Tizen::App( 1175): (119) > InstallationInProgress [100]
06-13 13:59:13.161+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
06-13 13:59:14.793+0900 E/PKGMGR_SERVER(15130): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-13 13:59:15.003+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:15.003+0900 I/Tizen::App( 1175): (1894) > PackageEventHandler - req: 11750002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
06-13 13:59:15.003+0900 E/PKGMGR  ( 4377): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-13 13:59:15.003+0900 I/Tizen::App( 1175): (78) > Installation is Completed. [Package = org.example.client]
06-13 13:59:15.003+0900 I/Tizen::App( 1175): (671) > Enter. package(org.example.client), installationResult(0)
06-13 13:59:15.003+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-13 13:59:15.003+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-13 13:59:15.003+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-13 13:59:15.013+0900 I/Tizen::App( 1175): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
06-13 13:59:15.033+0900 E/PKGMGR_SERVER(15130): pkgmgr-server.c: sighandler(417) > child NORMAL exit [15133]
06-13 13:59:15.033+0900 I/Tizen::App( 1175): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
06-13 13:59:15.043+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 13:59:15.043+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 13:59:15.053+0900 E/PKGMGR_INFO( 1175): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-13 13:59:15.053+0900 I/Tizen::App( 1175): (683) > Application count(1) in this package
06-13 13:59:15.053+0900 I/Tizen::App( 1175): (840) > Enter.
06-13 13:59:15.053+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-13 13:59:15.053+0900 I/Tizen::App( 1175): (703) > Exit.
06-13 13:59:15.053+0900 I/Tizen::App( 1175): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
06-13 13:59:15.053+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
06-13 13:59:15.063+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
06-13 13:59:15.063+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-13 13:59:15.063+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-13 13:59:15.063+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (416) > appName = [client]
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (131) > Enter
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (137) > org.example.client does not have launch condition
06-13 13:59:15.063+0900 I/Tizen::App( 1175): (883) > Exit.
06-13 13:59:15.073+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
06-13 13:59:15.073+0900 E/HOME_APPS( 1167): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
06-13 13:59:15.073+0900 E/cluster-home( 1167): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
06-13 13:59:15.073+0900 W/HOME_APPS( 1167): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
06-13 13:59:15.083+0900 E/util-view( 1167): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-13 13:59:16.795+0900 E/PKGMGR_SERVER(15130): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 13:59:16.795+0900 E/PKGMGR_SERVER(15130): pkgmgr-server.c: main(2471) > package manager server terminated.
06-13 13:59:19.347+0900 W/AUL     (15188): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
06-13 13:59:19.347+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 13:59:19.357+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-13 13:59:19.367+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-13 13:59:19.367+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-13 13:59:19.367+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 15188
06-13 13:59:19.367+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-13 13:59:19.377+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 13:59:19.377+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 13:59:19.377+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 13:59:19.377+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 13:59:19.377+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 13:59:19.397+0900 I/abc     (14613): abc
06-13 13:59:19.397+0900 I/CAPI_APPFW_APPLICATION(14613): app_main.c: ui_app_main(789) > app_efl_main
06-13 13:59:19.397+0900 I/CAPI_APPFW_APPLICATION(14613): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 13:59:19.427+0900 E/TBM     (14613): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 13:59:19.477+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14613, appid: org.example.client
06-13 13:59:19.477+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 13:59:19.487+0900 W/AUL     (15188): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14613)
06-13 13:59:19.878+0900 W/CRASH_MANAGER(15203): worker.c: worker_job(1199) > 0414613636c69149732995
